namespace SignToolUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseSignTool = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrowseCertificate = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxCertificatePath = new System.Windows.Forms.TextBox();
            this.textBoxTimestampURL = new System.Windows.Forms.TextBox();
            this.textBoxSignToolPath = new System.Windows.Forms.TextBox();
            this.checkBoxShowPwd = new System.Windows.Forms.CheckBox();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.checkBoxSubdirectories = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddDirectory = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.splitButtonSign = new wyDay.Controls.SplitButton();
            this.contextMenuSignSwitches = new System.Windows.Forms.ContextMenu();
            this.menuItemSignVerbose = new System.Windows.Forms.MenuItem();
            this.menuItemSignDebug = new System.Windows.Forms.MenuItem();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.checkBoxAll = new System.Windows.Forms.CheckBox();
            this.groupBoxFiles.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignTool.exe";
            // 
            // buttonBrowseSignTool
            // 
            this.buttonBrowseSignTool.Location = new System.Drawing.Point(489, 11);
            this.buttonBrowseSignTool.Name = "buttonBrowseSignTool";
            this.buttonBrowseSignTool.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseSignTool.TabIndex = 2;
            this.buttonBrowseSignTool.Text = "Browse...";
            this.buttonBrowseSignTool.UseVisualStyleBackColor = true;
            this.buttonBrowseSignTool.Click += new System.EventHandler(this.buttonBrowseSignTool_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "%programfiles%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timestamping server URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Certificate (.PFX)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Certificate Password";
            // 
            // buttonBrowseCertificate
            // 
            this.buttonBrowseCertificate.Location = new System.Drawing.Point(489, 63);
            this.buttonBrowseCertificate.Name = "buttonBrowseCertificate";
            this.buttonBrowseCertificate.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseCertificate.TabIndex = 7;
            this.buttonBrowseCertificate.Text = "Browse...";
            this.buttonBrowseCertificate.UseVisualStyleBackColor = true;
            this.buttonBrowseCertificate.Click += new System.EventHandler(this.buttonBrowseCertificate_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(141, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(342, 20);
            this.textBoxPassword.TabIndex = 9;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxCertificatePath
            // 
            this.textBoxCertificatePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SignToolUI.Properties.Settings.Default, "CertificatePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCertificatePath.Location = new System.Drawing.Point(141, 65);
            this.textBoxCertificatePath.Name = "textBoxCertificatePath";
            this.textBoxCertificatePath.Size = new System.Drawing.Size(342, 20);
            this.textBoxCertificatePath.TabIndex = 6;
            this.textBoxCertificatePath.Text = global::SignToolUI.Properties.Settings.Default.CertificatePath;
            // 
            // textBoxTimestampURL
            // 
            this.textBoxTimestampURL.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SignToolUI.Properties.Settings.Default, "TimestampServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxTimestampURL.Location = new System.Drawing.Point(141, 39);
            this.textBoxTimestampURL.Name = "textBoxTimestampURL";
            this.textBoxTimestampURL.Size = new System.Drawing.Size(342, 20);
            this.textBoxTimestampURL.TabIndex = 4;
            this.textBoxTimestampURL.Text = global::SignToolUI.Properties.Settings.Default.TimestampServer;
            // 
            // textBoxSignToolPath
            // 
            this.textBoxSignToolPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SignToolUI.Properties.Settings.Default, "SignToolPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxSignToolPath.Location = new System.Drawing.Point(141, 13);
            this.textBoxSignToolPath.Name = "textBoxSignToolPath";
            this.textBoxSignToolPath.Size = new System.Drawing.Size(342, 20);
            this.textBoxSignToolPath.TabIndex = 1;
            this.textBoxSignToolPath.Text = global::SignToolUI.Properties.Settings.Default.SignToolPath;
            // 
            // checkBoxShowPwd
            // 
            this.checkBoxShowPwd.AutoSize = true;
            this.checkBoxShowPwd.Location = new System.Drawing.Point(489, 94);
            this.checkBoxShowPwd.Name = "checkBoxShowPwd";
            this.checkBoxShowPwd.Size = new System.Drawing.Size(53, 17);
            this.checkBoxShowPwd.TabIndex = 10;
            this.checkBoxShowPwd.Text = "Show";
            this.checkBoxShowPwd.UseVisualStyleBackColor = true;
            this.checkBoxShowPwd.CheckedChanged += new System.EventHandler(this.checkBoxShowPwd_CheckedChanged);
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiles.Controls.Add(this.checkBoxAll);
            this.groupBoxFiles.Controls.Add(this.checkBoxSubdirectories);
            this.groupBoxFiles.Controls.Add(this.buttonClear);
            this.groupBoxFiles.Controls.Add(this.buttonAddDirectory);
            this.groupBoxFiles.Controls.Add(this.buttonAddFiles);
            this.groupBoxFiles.Controls.Add(this.checkedListBoxFiles);
            this.groupBoxFiles.Location = new System.Drawing.Point(12, 139);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Size = new System.Drawing.Size(570, 165);
            this.groupBoxFiles.TabIndex = 1;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // checkBoxSubdirectories
            // 
            this.checkBoxSubdirectories.AutoSize = true;
            this.checkBoxSubdirectories.Location = new System.Drawing.Point(265, 141);
            this.checkBoxSubdirectories.Name = "checkBoxSubdirectories";
            this.checkBoxSubdirectories.Size = new System.Drawing.Size(93, 17);
            this.checkBoxSubdirectories.TabIndex = 4;
            this.checkBoxSubdirectories.Text = "Subdirectories";
            this.checkBoxSubdirectories.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(6, 137);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(63, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddDirectory
            // 
            this.buttonAddDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDirectory.Location = new System.Drawing.Point(364, 137);
            this.buttonAddDirectory.Name = "buttonAddDirectory";
            this.buttonAddDirectory.Size = new System.Drawing.Size(97, 23);
            this.buttonAddDirectory.TabIndex = 2;
            this.buttonAddDirectory.Text = "Add directory";
            this.buttonAddDirectory.UseVisualStyleBackColor = true;
            this.buttonAddDirectory.Click += new System.EventHandler(this.buttonAddDirectory_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFiles.Location = new System.Drawing.Point(467, 137);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(97, 23);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "Add files...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.Size = new System.Drawing.Size(558, 109);
            this.checkedListBoxFiles.TabIndex = 0;
            this.checkedListBoxFiles.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.checkedListBoxFiles_ControlChanged);
            this.checkedListBoxFiles.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.checkedListBoxFiles_ControlChanged);
            this.checkedListBoxFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkedListBoxFiles_KeyDown);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(12, 310);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(570, 132);
            this.textBoxOutput.TabIndex = 2;
            this.textBoxOutput.Text = "Output will appear here...";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select a folder that contains the assemblies";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(58, 3);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(428, 23);
            this.progressBarStatus.Step = 1;
            this.progressBarStatus.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Progress";
            // 
            // panelProgress
            // 
            this.panelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProgress.Controls.Add(this.label5);
            this.panelProgress.Controls.Add(this.progressBarStatus);
            this.panelProgress.Location = new System.Drawing.Point(12, 448);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(489, 30);
            this.panelProgress.TabIndex = 4;
            this.panelProgress.Visible = false;
            // 
            // splitButtonSign
            // 
            this.splitButtonSign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButtonSign.AutoSize = true;
            this.splitButtonSign.Location = new System.Drawing.Point(507, 451);
            this.splitButtonSign.Name = "splitButtonSign";
            this.splitButtonSign.Size = new System.Drawing.Size(75, 23);
            this.splitButtonSign.SplitMenu = this.contextMenuSignSwitches;
            this.splitButtonSign.TabIndex = 3;
            this.splitButtonSign.Text = "Sign...";
            this.splitButtonSign.UseVisualStyleBackColor = true;
            this.splitButtonSign.Click += new System.EventHandler(this.splitButtonSign_Click);
            // 
            // contextMenuSignSwitches
            // 
            this.contextMenuSignSwitches.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemSignVerbose,
            this.menuItemSignDebug});
            // 
            // menuItemSignVerbose
            // 
            this.menuItemSignVerbose.Index = 0;
            this.menuItemSignVerbose.RadioCheck = true;
            this.menuItemSignVerbose.Text = "Verbose";
            this.menuItemSignVerbose.Click += new System.EventHandler(this.contextMenuItemSignOption_Click);
            // 
            // menuItemSignDebug
            // 
            this.menuItemSignDebug.Index = 1;
            this.menuItemSignDebug.RadioCheck = true;
            this.menuItemSignDebug.Text = "Debug";
            this.menuItemSignDebug.Click += new System.EventHandler(this.contextMenuItemSignOption_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.textBoxSignToolPath);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.textBoxTimestampURL);
            this.groupBoxDetails.Controls.Add(this.checkBoxShowPwd);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.buttonBrowseCertificate);
            this.groupBoxDetails.Controls.Add(this.textBoxCertificatePath);
            this.groupBoxDetails.Controls.Add(this.buttonBrowseSignTool);
            this.groupBoxDetails.Controls.Add(this.textBoxPassword);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(570, 121);
            this.groupBoxDetails.TabIndex = 0;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // checkBoxAll
            // 
            this.checkBoxAll.AutoSize = true;
            this.checkBoxAll.Location = new System.Drawing.Point(75, 141);
            this.checkBoxAll.Name = "checkBoxAll";
            this.checkBoxAll.Size = new System.Drawing.Size(37, 17);
            this.checkBoxAll.TabIndex = 5;
            this.checkBoxAll.Text = "All";
            this.checkBoxAll.UseVisualStyleBackColor = true;
            this.checkBoxAll.CheckedChanged += new System.EventHandler(this.checkBoxAll_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 487);
            this.Controls.Add(this.splitButtonSign);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.groupBoxFiles);
            this.Controls.Add(this.groupBoxDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 525);
            this.Name = "MainForm";
            this.Text = "Easy SignTool";
            this.groupBoxFiles.ResumeLayout(false);
            this.groupBoxFiles.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSignToolPath;
        private System.Windows.Forms.Button buttonBrowseSignTool;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimestampURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCertificatePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowseCertificate;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxShowPwd;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private System.Windows.Forms.Button buttonAddDirectory;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Button buttonClear;
        private wyDay.Controls.SplitButton splitButtonSign;
        private System.Windows.Forms.ContextMenu contextMenuSignSwitches;
        private System.Windows.Forms.MenuItem menuItemSignVerbose;
        private System.Windows.Forms.MenuItem menuItemSignDebug;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.CheckBox checkBoxSubdirectories;
        private System.Windows.Forms.CheckBox checkBoxAll;
    }
}

