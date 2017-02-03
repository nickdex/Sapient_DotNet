namespace DIITester
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
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMethod = new System.Windows.Forms.ListBox();
            this.listBoxProperty = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxField = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxConstructor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxTypes = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Invoke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(13, 13);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(29, 13);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(49, 13);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(557, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(613, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(694, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method";
            // 
            // listBoxMethod
            // 
            this.listBoxMethod.FormattingEnabled = true;
            this.listBoxMethod.Location = new System.Drawing.Point(140, 64);
            this.listBoxMethod.Name = "listBoxMethod";
            this.listBoxMethod.Size = new System.Drawing.Size(102, 199);
            this.listBoxMethod.TabIndex = 5;
            this.listBoxMethod.SelectedIndexChanged += new System.EventHandler(this.listBoxMethod_SelectedIndexChanged);
            // 
            // listBoxProperty
            // 
            this.listBoxProperty.FormattingEnabled = true;
            this.listBoxProperty.Location = new System.Drawing.Point(259, 64);
            this.listBoxProperty.Name = "listBoxProperty";
            this.listBoxProperty.Size = new System.Drawing.Size(102, 199);
            this.listBoxProperty.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Property";
            // 
            // listBoxField
            // 
            this.listBoxField.FormattingEnabled = true;
            this.listBoxField.Location = new System.Drawing.Point(384, 64);
            this.listBoxField.Name = "listBoxField";
            this.listBoxField.Size = new System.Drawing.Size(102, 199);
            this.listBoxField.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Field";
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.Location = new System.Drawing.Point(504, 64);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(102, 199);
            this.listBoxEvent.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Event";
            // 
            // listBoxConstructor
            // 
            this.listBoxConstructor.FormattingEnabled = true;
            this.listBoxConstructor.Location = new System.Drawing.Point(628, 64);
            this.listBoxConstructor.Name = "listBoxConstructor";
            this.listBoxConstructor.Size = new System.Drawing.Size(102, 199);
            this.listBoxConstructor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(658, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Constructor";
            // 
            // listBoxTypes
            // 
            this.listBoxTypes.FormattingEnabled = true;
            this.listBoxTypes.HorizontalScrollbar = true;
            this.listBoxTypes.Location = new System.Drawing.Point(12, 64);
            this.listBoxTypes.Name = "listBoxTypes";
            this.listBoxTypes.Size = new System.Drawing.Size(102, 199);
            this.listBoxTypes.TabIndex = 15;
            this.listBoxTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxTypes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Types";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 138);
            this.panel1.TabIndex = 16;
            // 
            // Invoke
            // 
            this.Invoke.Location = new System.Drawing.Point(486, 327);
            this.Invoke.Name = "Invoke";
            this.Invoke.Size = new System.Drawing.Size(75, 23);
            this.Invoke.TabIndex = 17;
            this.Invoke.Text = "Invoke";
            this.Invoke.UseVisualStyleBackColor = true;
            this.Invoke.Click += new System.EventHandler(this.Invoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 435);
            this.Controls.Add(this.Invoke);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxConstructor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxProperty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMethod;
        private System.Windows.Forms.ListBox listBoxProperty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxConstructor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxTypes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Invoke;
    }
}

