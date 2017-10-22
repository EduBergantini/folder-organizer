using System;
using System.Threading;
using System.Windows.Forms;
using Organizer.View.Presenters.Impls;
using Organizer.View.Presenters.Interfaces;
using Organizer.View.Views;

namespace Organizer.View
{
    public partial class MainForm : Form, IFolderManagerView
    {
        private readonly IFolderManagerPresenter _folderManagerPresenter;
        private readonly SynchronizationContext _synchronizationContext;

        public string DirectoryToOrganize
        {
            get => directoryToOrganizeTextBox.Text;
            set => directoryToOrganizeTextBox.Text = value;
        }

        public string OrganizationDiagnostic
        {
            get => organizationDiagnosticLabel.Text;
            set => organizationDiagnosticLabel.Text = value;
        }

        public bool CanOrganize
        {
            get => organizeActionPanel.Visible;
            set => organizeActionPanel.Visible = value;
        }

        public void SetOrganizationProgressBar(int min, int max, int step)
        {
            _synchronizationContext.Post(state => { organizationProgressBar.Minimum = (int)state; }, min);
            _synchronizationContext.Post(state => { organizationProgressBar.Maximum = (int)state; }, max);
            _synchronizationContext.Post(state => { organizationProgressBar.Step = (int)state; }, step);
        }

        public void UpdateOrganizationProgressBar(int value)
        {
            _synchronizationContext.Post(state => { organizationProgressBar.Value = (int)state; }, value);
        }

        public void ResetProgressBar()
        {
            _synchronizationContext.Post(state => { organizationProgressBar.Minimum = (int)state; }, 0);
            _synchronizationContext.Post(state => { organizationProgressBar.Maximum = (int)state; }, 0);
            _synchronizationContext.Post(state => { organizationProgressBar.Step = (int)state; }, 0);
            _synchronizationContext.Post(state => { organizationProgressBar.Value = (int)state; }, 0);
        }

        public MainForm()
        {
            InitializeComponent();
            _synchronizationContext = SynchronizationContext.Current;
            _folderManagerPresenter = new FolderManagerPresenter(this, _synchronizationContext);
        }

        private void OnSelectOrganizerClick(object sender, EventArgs e)
        {
            var searchResult = organizerFolderBrowserDialog.ShowDialog();
            if (searchResult != DialogResult.OK) return;
            _folderManagerPresenter.SetPathToOrganize(organizerFolderBrowserDialog.SelectedPath);
        }

        private async void OnOrganizeClick(object sender, EventArgs e)
        {
            await _folderManagerPresenter.OrganizeFolder();
        }
    }
}
