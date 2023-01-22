namespace Notat_app.Views;

/// <summary>
/// View for the 'About'-page.
/// </summary>
public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
        Application.Current.UserAppTheme = AppTheme.Light;

        InitializeComponent();
	}

    private async void ClickTutorial(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
    }

    private void ChangeTheme(object sender, EventArgs e)
    {
        if (Application.Current.UserAppTheme == AppTheme.Light)
            Application.Current.UserAppTheme = AppTheme.Dark;
        else
            Application.Current.UserAppTheme = AppTheme.Light;
    }
}