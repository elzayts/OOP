namespace Mini_excel_lab2
{
    partial class FormSaveFile
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
            this.labelWhereSave = new System.Windows.Forms.Label();
            this.TBpath = new System.Windows.Forms.TextBox();
            this.TBname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnSaveOK = new System.Windows.Forms.Button();
            this.btnStopSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWhereSave
            // 
            this.labelWhereSave.AutoSize = true;
            this.labelWhereSave.Location = new System.Drawing.Point(221, 120);
            this.labelWhereSave.Name = "labelWhereSave";
            this.labelWhereSave.Size = new System.Drawing.Size(37, 13);
            this.labelWhereSave.TabIndex = 0;
            this.labelWhereSave.Text = "Folder";
            // 
            // TBpath
            // 
            this.TBpath.Location = new System.Drawing.Point(293, 117);
            this.TBpath.Name = "TBpath";
            this.TBpath.Size = new System.Drawing.Size(159, 20);
            this.TBpath.TabIndex = 1;
            this.TBpath.Text = "C:\\OOP";
            this.TBpath.TextChanged += new System.EventHandler(this.TBpath_TextChanged);
            // 
            // TBname
            // 
            this.TBname.Location = new System.Drawing.Point(293, 159);
            this.TBname.Name = "TBname";
            this.TBname.Size = new System.Drawing.Size(159, 20);
            this.TBname.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(223, 162);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "File name";
            // 
            // btnSaveOK
            // 
            this.btnSaveOK.Location = new System.Drawing.Point(226, 229);
            this.btnSaveOK.Name = "btnSaveOK";
            this.btnSaveOK.Size = new System.Drawing.Size(75, 23);
            this.btnSaveOK.TabIndex = 4;
            this.btnSaveOK.Text = "OK";
            this.btnSaveOK.UseVisualStyleBackColor = true;
            this.btnSaveOK.Click += new System.EventHandler(this.btnSaveOK_Click);
            // 
            // btnStopSave
            // 
            this.btnStopSave.Location = new System.Drawing.Point(340, 229);
            this.btnStopSave.Name = "btnStopSave";
            this.btnStopSave.Size = new System.Drawing.Size(112, 23);
            this.btnStopSave.TabIndex = 5;
            this.btnStopSave.Text = "Cancel";
            this.btnStopSave.UseVisualStyleBackColor = true;
            this.btnStopSave.Click += new System.EventHandler(this.btnStopSave_Click);
            // 
            // FormSaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 441);
            this.Controls.Add(this.btnStopSave);
            this.Controls.Add(this.btnSaveOK);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.TBname);
            this.Controls.Add(this.TBpath);
            this.Controls.Add(this.labelWhereSave);
            this.Name = "FormSaveFile";
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhereSave;
        private System.Windows.Forms.TextBox TBpath;
        private System.Windows.Forms.TextBox TBname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnSaveOK;
        private System.Windows.Forms.Button btnStopSave;
    }
}
