
namespace auCDtect_Fronted
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
            this.components = new System.ComponentModel.Container();
            this.lstbxFiles = new System.Windows.Forms.ListBox();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnAnalizeFiles = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rtxtbxOutput = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lstbxFiles
            // 
            this.lstbxFiles.FormattingEnabled = true;
            this.lstbxFiles.HorizontalScrollbar = true;
            this.lstbxFiles.Location = new System.Drawing.Point(9, 9);
            this.lstbxFiles.Name = "lstbxFiles";
            this.lstbxFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstbxFiles.Size = new System.Drawing.Size(384, 238);
            this.lstbxFiles.TabIndex = 0;
            this.toolTip.SetToolTip(this.lstbxFiles, "Files for analysis");
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(399, 9);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(75, 23);
            this.btnAddFiles.TabIndex = 1;
            this.btnAddFiles.Text = "Add files";
            this.toolTip.SetToolTip(this.btnAddFiles, "Add files to be checked");
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFilesClick);
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(399, 38);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFile.TabIndex = 2;
            this.btnRemoveFile.Text = "Remove file";
            this.toolTip.SetToolTip(this.btnRemoveFile, "Remove selected files from the list");
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            this.btnRemoveFile.Click += new System.EventHandler(this.btnRemoveFileClick);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(399, 67);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear filelist";
            this.toolTip.SetToolTip(this.btnClearList, "Clear the list of files to be checked");
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearListClick);
            // 
            // btnAnalizeFiles
            // 
            this.btnAnalizeFiles.Location = new System.Drawing.Point(399, 115);
            this.btnAnalizeFiles.Name = "btnAnalizeFiles";
            this.btnAnalizeFiles.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizeFiles.TabIndex = 4;
            this.btnAnalizeFiles.Text = "Analize files";
            this.toolTip.SetToolTip(this.btnAnalizeFiles, "Starts the process of analyzing files");
            this.btnAnalizeFiles.UseVisualStyleBackColor = true;
            this.btnAnalizeFiles.Click += new System.EventHandler(this.btnAnalizeFilesClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(399, 166);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.toolTip.SetToolTip(this.btnHelp, "Display help information");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelpClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(399, 195);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "About";
            this.toolTip.SetToolTip(this.btnAbout, "Display information about program");
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAboutClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 224);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.toolTip.SetToolTip(this.btnExit, "Exit auCDtect Frontend");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExitClick);
            // 
            // rtxtbxOutput
            // 
            this.rtxtbxOutput.CausesValidation = false;
            this.rtxtbxOutput.Location = new System.Drawing.Point(9, 255);
            this.rtxtbxOutput.Name = "rtxtbxOutput";
            this.rtxtbxOutput.ReadOnly = true;
            this.rtxtbxOutput.Size = new System.Drawing.Size(465, 153);
            this.rtxtbxOutput.TabIndex = 8;
            this.rtxtbxOutput.Text = "";
            this.toolTip.SetToolTip(this.rtxtbxOutput, "The results of the analysis");
            this.rtxtbxOutput.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "wav";
            this.openFileDialog.Filter = "Music files (*.wav)|*.wav";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.ReadOnlyChecked = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.ShowReadOnly = true;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 418);
            this.Controls.Add(this.lstbxFiles);
            this.Controls.Add(this.btnAddFiles);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnAnalizeFiles);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtxtbxOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auCDtect Fronted";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstbxFilesDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstbxFilesDragEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxFiles;		
        private System.Windows.Forms.Button btnAddFiles;
	private System.Windows.Forms.Button btnRemoveFile;
	private System.Windows.Forms.Button btnClearList;
	private System.Windows.Forms.Button btnAnalizeFiles;
	private System.Windows.Forms.Button btnHelp;
	private System.Windows.Forms.Button btnAbout;
	private System.Windows.Forms.Button btnExit;
	private System.Windows.Forms.RichTextBox rtxtbxOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

