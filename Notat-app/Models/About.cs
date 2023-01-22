namespace Notat_app.Models
{
    /// <summary>
    /// Model for the 'About'-page.
    /// </summary>
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public Uri MoreInfoUrl => new("https://learn.microsoft.com/en-us/dotnet/maui/tutorials/notes-app/?view=net-maui-7.0");
        public string Message => "Dette er en app for å ta notater som er skrevet i .NET MAUI!";
        public string ButtonText => "Se guide";
    }
}
