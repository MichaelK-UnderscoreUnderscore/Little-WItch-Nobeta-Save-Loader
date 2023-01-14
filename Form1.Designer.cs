namespace LWNobeta_Save_Edit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.buttonReload = new System.Windows.Forms.Button();
            this.fswSave = new System.IO.FileSystemWatcher();
            this.listSaveFolder = new System.Windows.Forms.ListBox();
            this.numericSaveSlot = new System.Windows.Forms.NumericUpDown();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.timerSave = new System.Windows.Forms.Timer(this.components);
            this.labelStaticLoadedFile = new System.Windows.Forms.Label();
            this.labelLoadedFileName = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelBackupFileName = new System.Windows.Forms.Label();
            this.numericBackupSaveSlot = new System.Windows.Forms.NumericUpDown();
            this.labelStaticBackupFile = new System.Windows.Forms.Label();
            this.textBoxBackupSaveName = new System.Windows.Forms.TextBox();
            this.buttonSaveBackup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fswSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaveSlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBackupSaveSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.Location = new System.Drawing.Point(3, 3);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(490, 23);
            this.buttonReload.TabIndex = 15;
            this.buttonReload.Text = "Reload List";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // fswSave
            // 
            this.fswSave.EnableRaisingEvents = true;
            this.fswSave.SynchronizingObject = this;
            // 
            // listSaveFolder
            // 
            this.listSaveFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listSaveFolder.FormattingEnabled = true;
            this.listSaveFolder.Location = new System.Drawing.Point(3, 30);
            this.listSaveFolder.Name = "listSaveFolder";
            this.listSaveFolder.Size = new System.Drawing.Size(490, 173);
            this.listSaveFolder.TabIndex = 17;
            // 
            // numericSaveSlot
            // 
            this.numericSaveSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSaveSlot.Location = new System.Drawing.Point(461, 206);
            this.numericSaveSlot.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericSaveSlot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSaveSlot.Name = "numericSaveSlot";
            this.numericSaveSlot.Size = new System.Drawing.Size(32, 20);
            this.numericSaveSlot.TabIndex = 18;
            this.numericSaveSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(3, 204);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(452, 23);
            this.buttonLoad.TabIndex = 20;
            this.buttonLoad.Text = "Load Save to Slot";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // labelStaticLoadedFile
            // 
            this.labelStaticLoadedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStaticLoadedFile.AutoSize = true;
            this.labelStaticLoadedFile.Location = new System.Drawing.Point(3, 230);
            this.labelStaticLoadedFile.Name = "labelStaticLoadedFile";
            this.labelStaticLoadedFile.Size = new System.Drawing.Size(65, 13);
            this.labelStaticLoadedFile.TabIndex = 21;
            this.labelStaticLoadedFile.Text = "Loaded File:";
            // 
            // labelLoadedFileName
            // 
            this.labelLoadedFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoadedFileName.AutoSize = true;
            this.labelLoadedFileName.Location = new System.Drawing.Point(77, 230);
            this.labelLoadedFileName.Name = "labelLoadedFileName";
            this.labelLoadedFileName.Size = new System.Drawing.Size(33, 13);
            this.labelLoadedFileName.TabIndex = 22;
            this.labelLoadedFileName.Text = "None";
            this.labelLoadedFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonReload);
            this.splitContainer1.Panel1.Controls.Add(this.labelLoadedFileName);
            this.splitContainer1.Panel1.Controls.Add(this.listSaveFolder);
            this.splitContainer1.Panel1.Controls.Add(this.labelStaticLoadedFile);
            this.splitContainer1.Panel1.Controls.Add(this.numericSaveSlot);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoad);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelBackupFileName);
            this.splitContainer1.Panel2.Controls.Add(this.numericBackupSaveSlot);
            this.splitContainer1.Panel2.Controls.Add(this.labelStaticBackupFile);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBackupSaveName);
            this.splitContainer1.Panel2.Controls.Add(this.buttonSaveBackup);
            this.splitContainer1.Size = new System.Drawing.Size(498, 337);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 23;
            // 
            // labelBackupFileName
            // 
            this.labelBackupFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBackupFileName.AutoSize = true;
            this.labelBackupFileName.Location = new System.Drawing.Point(77, 55);
            this.labelBackupFileName.Name = "labelBackupFileName";
            this.labelBackupFileName.Size = new System.Drawing.Size(33, 13);
            this.labelBackupFileName.TabIndex = 24;
            this.labelBackupFileName.Text = "None";
            this.labelBackupFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // numericBackupSaveSlot
            // 
            this.numericBackupSaveSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericBackupSaveSlot.Location = new System.Drawing.Point(461, 29);
            this.numericBackupSaveSlot.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericBackupSaveSlot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBackupSaveSlot.Name = "numericBackupSaveSlot";
            this.numericBackupSaveSlot.Size = new System.Drawing.Size(32, 20);
            this.numericBackupSaveSlot.TabIndex = 23;
            this.numericBackupSaveSlot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelStaticBackupFile
            // 
            this.labelStaticBackupFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStaticBackupFile.AutoSize = true;
            this.labelStaticBackupFile.Location = new System.Drawing.Point(3, 55);
            this.labelStaticBackupFile.Name = "labelStaticBackupFile";
            this.labelStaticBackupFile.Size = new System.Drawing.Size(66, 13);
            this.labelStaticBackupFile.TabIndex = 23;
            this.labelStaticBackupFile.Text = "Backup File:";
            // 
            // textBoxBackupSaveName
            // 
            this.textBoxBackupSaveName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBackupSaveName.Location = new System.Drawing.Point(3, 3);
            this.textBoxBackupSaveName.Name = "textBoxBackupSaveName";
            this.textBoxBackupSaveName.Size = new System.Drawing.Size(490, 20);
            this.textBoxBackupSaveName.TabIndex = 1;
            this.textBoxBackupSaveName.Text = "Default Backup Name";
            // 
            // buttonSaveBackup
            // 
            this.buttonSaveBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveBackup.Location = new System.Drawing.Point(3, 29);
            this.buttonSaveBackup.Name = "buttonSaveBackup";
            this.buttonSaveBackup.Size = new System.Drawing.Size(452, 23);
            this.buttonSaveBackup.TabIndex = 0;
            this.buttonSaveBackup.Text = "Backup Saveslot to Filename";
            this.buttonSaveBackup.UseVisualStyleBackColor = true;
            this.buttonSaveBackup.Click += new System.EventHandler(this.buttonSaveBackup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 361);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "LWN - Save Loader";
            ((System.ComponentModel.ISupportInitialize)(this.fswSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaveSlot)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericBackupSaveSlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonReload;
        private System.IO.FileSystemWatcher fswSave;
        private System.Windows.Forms.NumericUpDown numericSaveSlot;
        private System.Windows.Forms.ListBox listSaveFolder;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Timer timerSave;
        private System.Windows.Forms.Label labelLoadedFileName;
        private System.Windows.Forms.Label labelStaticLoadedFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown numericBackupSaveSlot;
        private System.Windows.Forms.TextBox textBoxBackupSaveName;
        private System.Windows.Forms.Button buttonSaveBackup;
        private System.Windows.Forms.Label labelBackupFileName;
        private System.Windows.Forms.Label labelStaticBackupFile;
    }
}

