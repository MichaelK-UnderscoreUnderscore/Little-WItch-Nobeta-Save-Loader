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
            ((System.ComponentModel.ISupportInitialize)(this.fswSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaveSlot)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.Location = new System.Drawing.Point(12, 14);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(262, 23);
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
            this.listSaveFolder.Location = new System.Drawing.Point(12, 41);
            this.listSaveFolder.Name = "listSaveFolder";
            this.listSaveFolder.Size = new System.Drawing.Size(262, 290);
            this.listSaveFolder.TabIndex = 17;
            // 
            // numericSaveSlot
            // 
            this.numericSaveSlot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericSaveSlot.Location = new System.Drawing.Point(245, 346);
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
            this.buttonLoad.Location = new System.Drawing.Point(12, 345);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(227, 23);
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
            this.labelStaticLoadedFile.Location = new System.Drawing.Point(12, 371);
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
            this.labelLoadedFileName.Location = new System.Drawing.Point(83, 371);
            this.labelLoadedFileName.Name = "labelLoadedFileName";
            this.labelLoadedFileName.Size = new System.Drawing.Size(33, 13);
            this.labelLoadedFileName.TabIndex = 22;
            this.labelLoadedFileName.Text = "None";
            this.labelLoadedFileName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(286, 393);
            this.Controls.Add(this.labelLoadedFileName);
            this.Controls.Add(this.numericSaveSlot);
            this.Controls.Add(this.labelStaticLoadedFile);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.listSaveFolder);
            this.Controls.Add(this.buttonReload);
            this.MinimumSize = new System.Drawing.Size(185, 245);
            this.Name = "Form1";
            this.Text = "LWN - Save Loader";
            ((System.ComponentModel.ISupportInitialize)(this.fswSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaveSlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

