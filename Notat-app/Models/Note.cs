namespace Notat_app.Models
{
    /// <summary>
    /// Model for the 'Note'-page.
    /// </summary>
    internal class Note
    {
        public string Filename { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
