namespace Mini_excel_lab2
{
    partial class FormLoadFile
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
            this.lblPapka = new System.Windows.Forms.Label();
            this.TBpapka = new System.Windows.Forms.TextBox();
            this.TextBoxFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPapka
            // 
            this.lblPapka.AutoSize = true;
            this.lblPapka.Location = new System.Drawing.Point(248, 110);
            this.lblPapka.Name = "lblPapka";
            this.lblPapka.Size = new System.Drawing.Size(39, 13);
            this.lblPapka.TabIndex = 0;
            this.lblPapka.Text = "Folfer";
            // 
            // TBpapka
            // 
            this.TBpapka.Location = new System.Drawing.Point(332, 110);
            this.TBpapka.Name = "TBpapka";
            this.TBpapka.Size = new System.Drawing.Size(175, 20);
            this.TBpapka.TabIndex = 1;
            this.TBpapka.Text = "C:\\OOP";
            
            // 
            // listBoxFiles
            // 
            this.TextBoxFile.Location = new System.Drawing.Point(332, 155);
            this.TextBoxFile.Name = "listBoxFiles";
            this.TextBoxFile.Size = new System.Drawing.Size(327, 134);
            this.TextBoxFile.TabIndex = 2;
            this.TextBoxFile.Text = "";
            
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(251, 155);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(36, 13);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "File";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(254, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(389, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormLoadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.TextBoxFile);
            this.Controls.Add(this.TBpapka);
            this.Controls.Add(this.lblPapka);
            this.Name = "FormLoadFile";
            this.Text = "FormLoadFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPapka;
        private System.Windows.Forms.TextBox TBpapka;
        private System.Windows.Forms.TextBox TextBoxFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClose;
    }
}