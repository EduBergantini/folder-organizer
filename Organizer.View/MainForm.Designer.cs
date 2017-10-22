namespace Organizer.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.organizerTabPage = new System.Windows.Forms.TabPage();
            this.organizeActionPanel = new System.Windows.Forms.Panel();
            this.organizationDiagnosticLabel = new System.Windows.Forms.Label();
            this.organizeFolderButton = new System.Windows.Forms.Button();
            this.organizationProgressBar = new System.Windows.Forms.ProgressBar();
            this.organizerDescriptionLabel = new System.Windows.Forms.Label();
            this.searchFolderToOrganizeButton = new System.Windows.Forms.Button();
            this.directoryToOrganizeTextBox = new System.Windows.Forms.TextBox();
            this.moverTabPage = new System.Windows.Forms.TabPage();
            this.organizerFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.organizerTabPage.SuspendLayout();
            this.organizeActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.organizerTabPage);
            this.tabControl.Controls.Add(this.moverTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(518, 262);
            this.tabControl.TabIndex = 0;
            // 
            // organizerTabPage
            // 
            this.organizerTabPage.Controls.Add(this.organizeActionPanel);
            this.organizerTabPage.Controls.Add(this.organizerDescriptionLabel);
            this.organizerTabPage.Controls.Add(this.searchFolderToOrganizeButton);
            this.organizerTabPage.Controls.Add(this.directoryToOrganizeTextBox);
            this.organizerTabPage.Location = new System.Drawing.Point(4, 26);
            this.organizerTabPage.Name = "organizerTabPage";
            this.organizerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.organizerTabPage.Size = new System.Drawing.Size(510, 232);
            this.organizerTabPage.TabIndex = 0;
            this.organizerTabPage.Text = "Organize";
            this.organizerTabPage.UseVisualStyleBackColor = true;
            // 
            // organizeActionPanel
            // 
            this.organizeActionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizeActionPanel.Controls.Add(this.organizationDiagnosticLabel);
            this.organizeActionPanel.Controls.Add(this.organizeFolderButton);
            this.organizeActionPanel.Controls.Add(this.organizationProgressBar);
            this.organizeActionPanel.Location = new System.Drawing.Point(6, 63);
            this.organizeActionPanel.Name = "organizeActionPanel";
            this.organizeActionPanel.Size = new System.Drawing.Size(498, 162);
            this.organizeActionPanel.TabIndex = 3;
            this.organizeActionPanel.Visible = false;
            // 
            // organizationDiagnosticLabel
            // 
            this.organizationDiagnosticLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationDiagnosticLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizationDiagnosticLabel.Location = new System.Drawing.Point(3, 67);
            this.organizationDiagnosticLabel.Name = "organizationDiagnosticLabel";
            this.organizationDiagnosticLabel.Size = new System.Drawing.Size(492, 95);
            this.organizationDiagnosticLabel.TabIndex = 2;
            this.organizationDiagnosticLabel.Text = "Click Proccess to initialize.";
            this.organizationDiagnosticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organizeFolderButton
            // 
            this.organizeFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizeFolderButton.Location = new System.Drawing.Point(201, 3);
            this.organizeFolderButton.Name = "organizeFolderButton";
            this.organizeFolderButton.Size = new System.Drawing.Size(94, 32);
            this.organizeFolderButton.TabIndex = 1;
            this.organizeFolderButton.Text = "Process";
            this.organizeFolderButton.UseVisualStyleBackColor = true;
            this.organizeFolderButton.Click += new System.EventHandler(this.OnOrganizeClick);
            // 
            // organizationProgressBar
            // 
            this.organizationProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationProgressBar.Location = new System.Drawing.Point(3, 41);
            this.organizationProgressBar.Name = "organizationProgressBar";
            this.organizationProgressBar.Size = new System.Drawing.Size(492, 23);
            this.organizationProgressBar.TabIndex = 0;
            // 
            // organizerDescriptionLabel
            // 
            this.organizerDescriptionLabel.AutoSize = true;
            this.organizerDescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizerDescriptionLabel.Location = new System.Drawing.Point(6, 12);
            this.organizerDescriptionLabel.Name = "organizerDescriptionLabel";
            this.organizerDescriptionLabel.Size = new System.Drawing.Size(97, 17);
            this.organizerDescriptionLabel.TabIndex = 2;
            this.organizerDescriptionLabel.Text = "Select a folder:";
            // 
            // searchFolderToOrganizeButton
            // 
            this.searchFolderToOrganizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFolderToOrganizeButton.Location = new System.Drawing.Point(412, 32);
            this.searchFolderToOrganizeButton.Name = "searchFolderToOrganizeButton";
            this.searchFolderToOrganizeButton.Size = new System.Drawing.Size(92, 25);
            this.searchFolderToOrganizeButton.TabIndex = 1;
            this.searchFolderToOrganizeButton.Text = "Select";
            this.searchFolderToOrganizeButton.UseVisualStyleBackColor = true;
            this.searchFolderToOrganizeButton.Click += new System.EventHandler(this.OnSelectOrganizerClick);
            // 
            // directoryToOrganizeTextBox
            // 
            this.directoryToOrganizeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryToOrganizeTextBox.Location = new System.Drawing.Point(6, 32);
            this.directoryToOrganizeTextBox.Name = "directoryToOrganizeTextBox";
            this.directoryToOrganizeTextBox.ReadOnly = true;
            this.directoryToOrganizeTextBox.Size = new System.Drawing.Size(400, 25);
            this.directoryToOrganizeTextBox.TabIndex = 0;
            // 
            // moverTabPage
            // 
            this.moverTabPage.Location = new System.Drawing.Point(4, 22);
            this.moverTabPage.Name = "moverTabPage";
            this.moverTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.moverTabPage.Size = new System.Drawing.Size(510, 236);
            this.moverTabPage.TabIndex = 1;
            this.moverTabPage.Text = "Smart Move";
            this.moverTabPage.UseVisualStyleBackColor = true;
            // 
            // organizerFolderBrowserDialog
            // 
            this.organizerFolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(542, 286);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Images Folder Manager";
            this.tabControl.ResumeLayout(false);
            this.organizerTabPage.ResumeLayout(false);
            this.organizerTabPage.PerformLayout();
            this.organizeActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage organizerTabPage;
        private System.Windows.Forms.TabPage moverTabPage;
        private System.Windows.Forms.Button searchFolderToOrganizeButton;
        private System.Windows.Forms.TextBox directoryToOrganizeTextBox;
        private System.Windows.Forms.Label organizerDescriptionLabel;
        private System.Windows.Forms.FolderBrowserDialog organizerFolderBrowserDialog;
        private System.Windows.Forms.Panel organizeActionPanel;
        private System.Windows.Forms.Button organizeFolderButton;
        private System.Windows.Forms.ProgressBar organizationProgressBar;
        private System.Windows.Forms.Label organizationDiagnosticLabel;
    }
}

