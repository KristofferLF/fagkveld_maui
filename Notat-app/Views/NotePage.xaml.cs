namespace Notat_app.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class NotePage : ContentPage
{
    public string ItemId { set { LoadNote(value); } }

    public NotePage()
	{
		InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

        LoadNote(Path.Combine(appDataPath, randomFileName));
    }

    private void LoadNote(string Filename)
    {
        Models.Note note = new()
        {
            Filename = Filename
        };

        if (File.Exists(Filename))
        {
            note.Date = File.GetCreationTime(Filename);
            note.Text = File.ReadAllText(Filename);
        }

        BindingContext = note;
    }

    /// <summary>
    /// Button to save the current note.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ClickSaveButton(object sender, EventArgs e)
    {
        if (BindingContext is Models.Note note)
            File.WriteAllText(note.Filename, TextEditor.Text);

        await Shell.Current.GoToAsync("..");
    }

    /// <summary>
    /// Button to delete the current note.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ClickDeleteButton(object sender, EventArgs e)
    {
        if (BindingContext is Models.Note note)
        {
            // Delete the file.
            if (File.Exists(note.Filename))
                File.Delete(note.Filename);
        }

        await Shell.Current.GoToAsync("..");
    }

}