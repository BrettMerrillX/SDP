namespace SDP {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.openFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblChosenFolder = new System.Windows.Forms.Label();
            this.txtLinesPerFile = new System.Windows.Forms.TextBox();
            this.txtMaxFiles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxFiles = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnShowHeader = new System.Windows.Forms.Button();
            this.lstHeader = new System.Windows.Forms.ListBox();
            this.chkHasFieldsEnclosedInQuotes = new System.Windows.Forms.CheckBox();
            this.chkKeepHeader = new System.Windows.Forms.CheckBox();
            this.txtHeader = new System.Windows.Forms.TextBox();
            this.txtFooter = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblFooter = new System.Windows.Forms.Label();
            this.btnMakeImportFile = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnUnZip = new System.Windows.Forms.Button();
            this.fileHeader = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRevertToOriginal = new System.Windows.Forms.Button();
            this.btnRenameColumn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(25, 27);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(128, 41);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblChosenFolder
            // 
            this.lblChosenFolder.AutoSize = true;
            this.lblChosenFolder.Location = new System.Drawing.Point(174, 31);
            this.lblChosenFolder.Name = "lblChosenFolder";
            this.lblChosenFolder.Size = new System.Drawing.Size(0, 17);
            this.lblChosenFolder.TabIndex = 1;
            // 
            // txtLinesPerFile
            // 
            this.txtLinesPerFile.Location = new System.Drawing.Point(317, 273);
            this.txtLinesPerFile.Name = "txtLinesPerFile";
            this.txtLinesPerFile.Size = new System.Drawing.Size(100, 22);
            this.txtLinesPerFile.TabIndex = 2;
            // 
            // txtMaxFiles
            // 
            this.txtMaxFiles.Location = new System.Drawing.Point(438, 273);
            this.txtMaxFiles.Name = "txtMaxFiles";
            this.txtMaxFiles.Size = new System.Drawing.Size(100, 22);
            this.txtMaxFiles.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lines Per File";
            // 
            // lblMaxFiles
            // 
            this.lblMaxFiles.AutoSize = true;
            this.lblMaxFiles.Location = new System.Drawing.Point(435, 252);
            this.lblMaxFiles.Name = "lblMaxFiles";
            this.lblMaxFiles.Size = new System.Drawing.Size(66, 17);
            this.lblMaxFiles.TabIndex = 5;
            this.lblMaxFiles.Text = "Max Files";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(546, 268);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(107, 32);
            this.btnSplit.TabIndex = 6;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 16;
            this.lstFiles.Location = new System.Drawing.Point(25, 82);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstFiles.Size = new System.Drawing.Size(639, 116);
            this.lstFiles.TabIndex = 7;
            // 
            // btnShowHeader
            // 
            this.btnShowHeader.Location = new System.Drawing.Point(25, 326);
            this.btnShowHeader.Name = "btnShowHeader";
            this.btnShowHeader.Size = new System.Drawing.Size(104, 30);
            this.btnShowHeader.TabIndex = 8;
            this.btnShowHeader.Text = "Show Header";
            this.btnShowHeader.UseVisualStyleBackColor = true;
            this.btnShowHeader.Click += new System.EventHandler(this.btnShowHeader_Click);
            // 
            // lstHeader
            // 
            this.lstHeader.FormattingEnabled = true;
            this.lstHeader.ItemHeight = 16;
            this.lstHeader.Location = new System.Drawing.Point(26, 385);
            this.lstHeader.MultiColumn = true;
            this.lstHeader.Name = "lstHeader";
            this.lstHeader.Size = new System.Drawing.Size(309, 100);
            this.lstHeader.TabIndex = 9;
            // 
            // chkHasFieldsEnclosedInQuotes
            // 
            this.chkHasFieldsEnclosedInQuotes.AutoSize = true;
            this.chkHasFieldsEnclosedInQuotes.Location = new System.Drawing.Point(177, 323);
            this.chkHasFieldsEnclosedInQuotes.Name = "chkHasFieldsEnclosedInQuotes";
            this.chkHasFieldsEnclosedInQuotes.Size = new System.Drawing.Size(153, 38);
            this.chkHasFieldsEnclosedInQuotes.TabIndex = 10;
            this.chkHasFieldsEnclosedInQuotes.Text = "Has Fields \r\nEnclosed In Quotes";
            this.chkHasFieldsEnclosedInQuotes.UseVisualStyleBackColor = true;
            // 
            // chkKeepHeader
            // 
            this.chkKeepHeader.AutoSize = true;
            this.chkKeepHeader.Location = new System.Drawing.Point(337, 332);
            this.chkKeepHeader.Name = "chkKeepHeader";
            this.chkKeepHeader.Size = new System.Drawing.Size(114, 21);
            this.chkKeepHeader.TabIndex = 11;
            this.chkKeepHeader.Text = "Keep Header";
            this.chkKeepHeader.UseVisualStyleBackColor = true;
            // 
            // txtHeader
            // 
            this.txtHeader.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtHeader.Location = new System.Drawing.Point(27, 273);
            this.txtHeader.Multiline = true;
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(103, 20);
            this.txtHeader.TabIndex = 12;
            // 
            // txtFooter
            // 
            this.txtFooter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtFooter.Location = new System.Drawing.Point(136, 273);
            this.txtFooter.Multiline = true;
            this.txtFooter.Name = "txtFooter";
            this.txtFooter.Size = new System.Drawing.Size(104, 22);
            this.txtFooter.TabIndex = 13;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.ForeColor = System.Drawing.Color.Silver;
            this.lblHeader.Location = new System.Drawing.Point(24, 253);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(55, 17);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Header";
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.ForeColor = System.Drawing.Color.Silver;
            this.lblFooter.Location = new System.Drawing.Point(133, 253);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(49, 17);
            this.lblFooter.TabIndex = 15;
            this.lblFooter.Text = "Footer";
            // 
            // btnMakeImportFile
            // 
            this.btnMakeImportFile.Location = new System.Drawing.Point(506, 544);
            this.btnMakeImportFile.Name = "btnMakeImportFile";
            this.btnMakeImportFile.Size = new System.Drawing.Size(146, 30);
            this.btnMakeImportFile.TabIndex = 16;
            this.btnMakeImportFile.Text = "Make Import File";
            this.btnMakeImportFile.UseVisualStyleBackColor = true;
            this.btnMakeImportFile.Click += new System.EventHandler(this.btnMakeImportFile_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(565, 55);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(88, 21);
            this.chkSelectAll.TabIndex = 17;
            this.chkSelectAll.Text = "Select All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnUnZip
            // 
            this.btnUnZip.Location = new System.Drawing.Point(549, 208);
            this.btnUnZip.Name = "btnUnZip";
            this.btnUnZip.Size = new System.Drawing.Size(103, 29);
            this.btnUnZip.TabIndex = 18;
            this.btnUnZip.Text = "Un-Zip";
            this.btnUnZip.UseVisualStyleBackColor = true;
            this.btnUnZip.Click += new System.EventHandler(this.btnUnZip_Click);
            // 
            // fileHeader
            // 
            this.fileHeader.FormattingEnabled = true;
            this.fileHeader.ItemHeight = 16;
            this.fileHeader.Location = new System.Drawing.Point(341, 385);
            this.fileHeader.MultiColumn = true;
            this.fileHeader.Name = "fileHeader";
            this.fileHeader.Size = new System.Drawing.Size(323, 100);
            this.fileHeader.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "File Header";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "DataBase Header";
            // 
            // btnRevertToOriginal
            // 
            this.btnRevertToOriginal.Location = new System.Drawing.Point(506, 491);
            this.btnRevertToOriginal.Name = "btnRevertToOriginal";
            this.btnRevertToOriginal.Size = new System.Drawing.Size(146, 30);
            this.btnRevertToOriginal.TabIndex = 21;
            this.btnRevertToOriginal.Text = "Revert To Original ";
            this.btnRevertToOriginal.UseVisualStyleBackColor = true;
            this.btnRevertToOriginal.Click += new System.EventHandler(this.btnRevertToOriginal_Click);
            // 
            // btnRenameColumn
            // 
            this.btnRenameColumn.Location = new System.Drawing.Point(341, 491);
            this.btnRenameColumn.Name = "btnRenameColumn";
            this.btnRenameColumn.Size = new System.Drawing.Size(146, 30);
            this.btnRenameColumn.TabIndex = 22;
            this.btnRenameColumn.Text = "Rename Column";
            this.btnRenameColumn.UseVisualStyleBackColor = true;
            this.btnRenameColumn.Click += new System.EventHandler(this.btnRenameColumn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 586);
            this.Controls.Add(this.btnRenameColumn);
            this.Controls.Add(this.btnRevertToOriginal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUnZip);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.btnMakeImportFile);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtFooter);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.chkKeepHeader);
            this.Controls.Add(this.chkHasFieldsEnclosedInQuotes);
            this.Controls.Add(this.fileHeader);
            this.Controls.Add(this.lstHeader);
            this.Controls.Add(this.btnShowHeader);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lblMaxFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxFiles);
            this.Controls.Add(this.txtLinesPerFile);
            this.Controls.Add(this.lblChosenFolder);
            this.Controls.Add(this.btnChooseFolder);
            this.Name = "frmMain";
            this.Text = "SDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileBrowser;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lblChosenFolder;
        private System.Windows.Forms.TextBox txtLinesPerFile;
        private System.Windows.Forms.TextBox txtMaxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaxFiles;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnShowHeader;
        private System.Windows.Forms.ListBox lstHeader;
        private System.Windows.Forms.CheckBox chkHasFieldsEnclosedInQuotes;
        private System.Windows.Forms.CheckBox chkKeepHeader;
        private System.Windows.Forms.TextBox txtHeader;
        private System.Windows.Forms.TextBox txtFooter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Button btnMakeImportFile;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnUnZip;
        private System.Windows.Forms.ListBox fileHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRevertToOriginal;
        private System.Windows.Forms.Button btnRenameColumn;
    }
}

