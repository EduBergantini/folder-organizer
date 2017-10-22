namespace Organizer.View.Views
{
    public interface IFolderManagerView
    {
        string DirectoryToOrganize { get; set; }
        string OrganizationDiagnostic { get; set; }
        bool CanOrganize { get; set; }
        void SetOrganizationProgressBar(int min, int max, int step);
        void UpdateOrganizationProgressBar(int value);
        void ResetProgressBar();
    }
}