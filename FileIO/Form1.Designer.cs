namespace FileIO
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtBoxContent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.btnFolderBrowse = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.btnShowFilesAndFolder = new System.Windows.Forms.Button();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowseForCopy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(383, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(53, 14);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(324, 20);
            this.txtBoxPath.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(464, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtBoxContent
            // 
            this.txtBoxContent.Location = new System.Drawing.Point(15, 56);
            this.txtBoxContent.Multiline = true;
            this.txtBoxContent.Name = "txtBoxContent";
            this.txtBoxContent.Size = new System.Drawing.Size(125, 70);
            this.txtBoxContent.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(43, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(203, 56);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(205, 20);
            this.txtFolderPath.TabIndex = 6;
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(168, 56);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(61, 13);
            this.lblFolderPath.TabIndex = 7;
            this.lblFolderPath.Text = "Folder Path";
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Location = new System.Drawing.Point(414, 56);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(99, 23);
            this.btnFolderBrowse.TabIndex = 8;
            this.btnFolderBrowse.Text = "Browse Folder";
            this.btnFolderBrowse.UseVisualStyleBackColor = true;
            this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(203, 98);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(205, 56);
            this.listBoxFiles.TabIndex = 9;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // btnShowFilesAndFolder
            // 
            this.btnShowFilesAndFolder.Location = new System.Drawing.Point(414, 117);
            this.btnShowFilesAndFolder.Name = "btnShowFilesAndFolder";
            this.btnShowFilesAndFolder.Size = new System.Drawing.Size(84, 23);
            this.btnShowFilesAndFolder.TabIndex = 10;
            this.btnShowFilesAndFolder.Text = "Refresh";
            this.btnShowFilesAndFolder.UseVisualStyleBackColor = true;
            this.btnShowFilesAndFolder.Click += new System.EventHandler(this.btnShowFilesAndFolder_Click);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Location = new System.Drawing.Point(200, 82);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(51, 13);
            this.lblFileInfo.TabIndex = 11;
            this.lblFileInfo.Text = "lblFileInfo";
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(414, 175);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(84, 23);
            this.btnCreateFolder.TabIndex = 12;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.Location = new System.Drawing.Point(203, 160);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(205, 56);
            this.listBoxFolders.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "New Location";
            // 
            // btnBrowseForCopy
            // 
            this.btnBrowseForCopy.Location = new System.Drawing.Point(446, 220);
            this.btnBrowseForCopy.Name = "btnBrowseForCopy";
            this.btnBrowseForCopy.Size = new System.Drawing.Size(99, 23);
            this.btnBrowseForCopy.TabIndex = 16;
            this.btnBrowseForCopy.Text = "Browse Folder";
            this.btnBrowseForCopy.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBrowseForCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.lblFileInfo);
            this.Controls.Add(this.btnShowFilesAndFolder);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.btnFolderBrowse);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxContent);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtBoxContent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button btnShowFilesAndFolder;
        private System.Windows.Forms.Label lblFileInfo;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowseForCopy;
        private System.Windows.Forms.Button button1;
    }
}

