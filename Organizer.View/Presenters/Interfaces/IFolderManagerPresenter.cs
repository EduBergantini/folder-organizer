using System.Threading.Tasks;

namespace Organizer.View.Presenters.Interfaces
{
    internal interface IFolderManagerPresenter
    {
        void SetPathToOrganize(string selectedPath);
        Task OrganizeFolder();
    }
}