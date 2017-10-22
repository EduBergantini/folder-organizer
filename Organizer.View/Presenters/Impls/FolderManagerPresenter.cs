using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Organizer.View.Extensions;
using Organizer.View.Presenters.Interfaces;
using Organizer.View.Properties;
using Organizer.View.Views;

namespace Organizer.View.Presenters.Impls
{
    public class FolderManagerPresenter : IFolderManagerPresenter
    {
        private readonly IFolderManagerView _folderManagerView;
        private readonly SynchronizationContext _synchronizationContext;

        public FolderManagerPresenter(IFolderManagerView folderManagerView, SynchronizationContext synchronizationContext)
        {
            _folderManagerView = folderManagerView;
            _synchronizationContext = synchronizationContext;
        }

        public void SetPathToOrganize(string selectedPath)
        {
            _folderManagerView.DirectoryToOrganize = selectedPath;
            _folderManagerView.CanOrganize = Directory.Exists(selectedPath);
        }

        public Task OrganizeFolder()
        {
            return Task.Factory.StartNew(() =>
            {
                var filesToOrganize = Directory.GetFiles(_folderManagerView.DirectoryToOrganize)
                    .ToFileInfoList()
                    .OrderBy(info => info.CreationTime)
                    .ToList();
                if (filesToOrganize.Count == 0)
                {
                    Report(Resources.NoFileFound);
                    return;
                }
                Report(Resources.TotalFilesFound, filesToOrganize.Count);
                var step = filesToOrganize.Count / 100;
                _folderManagerView.SetOrganizationProgressBar(0, filesToOrganize.Count, step);
                for (int i = 0; i < filesToOrganize.Count; i++)
                {
                    var fileInfo = filesToOrganize[i];
                    var yearDirectory = GetFileDirectory(fileInfo);
                    Report(Resources.MovingFile, fileInfo.Name, yearDirectory);
                    File.Move(fileInfo.FullName, Path.Combine(yearDirectory, fileInfo.Name));
                    _folderManagerView.UpdateOrganizationProgressBar(i);
                }
                Report(Resources.ProcessFinished);
                _folderManagerView.ResetProgressBar();
            });
        }

        private static string GetFileDirectory(FileInfo fileInfo)
        {
            var byDateDirectory = Path.Combine(fileInfo.DirectoryName, fileInfo.CreationTime.Year.ToString(), fileInfo.CreationTime.ToString("MMMM"));
            if (!Directory.Exists(byDateDirectory)) Directory.CreateDirectory(byDateDirectory);
            return byDateDirectory;

        }

        public void Report(string value, params object[] replacer)
        {
            _synchronizationContext.Post(state =>
            {
                _folderManagerView.OrganizationDiagnostic = state.ToString();
            }, string.Format(value, replacer));
        }
    }
}