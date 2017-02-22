namespace WindowsHost
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
            this.bntHost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntHost
            // 
            this.bntHost.Location = new System.Drawing.Point(96, 65);
            this.bntHost.Name = "bntHost";
            this.bntHost.Size = new System.Drawing.Size(75, 23);
            this.bntHost.TabIndex = 0;
            this.bntHost.Text = "Host";
            this.bntHost.UseVisualStyleBackColor = true;
            this.bntHost.Click += new System.EventHandler(this.bntHost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntHost;
    }
}

