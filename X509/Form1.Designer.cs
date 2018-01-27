namespace X509
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
            this.selectCertFile = new System.Windows.Forms.Button();
            this.certPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orginalText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.openCertDialog = new System.Windows.Forms.OpenFileDialog();
            this.encryptedText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectCertFile
            // 
            this.selectCertFile.Location = new System.Drawing.Point(13, 13);
            this.selectCertFile.Name = "selectCertFile";
            this.selectCertFile.Size = new System.Drawing.Size(236, 23);
            this.selectCertFile.TabIndex = 0;
            this.selectCertFile.Text = "select .p12 cert file";
            this.selectCertFile.UseVisualStyleBackColor = true;
            this.selectCertFile.Click += new System.EventHandler(this.selectCertFile_Click);
            // 
            // certPassword
            // 
            this.certPassword.Location = new System.Drawing.Point(444, 15);
            this.certPassword.Name = "certPassword";
            this.certPassword.PasswordChar = '*';
            this.certPassword.Size = new System.Drawing.Size(236, 20);
            this.certPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cert password";
            // 
            // orginalText
            // 
            this.orginalText.Location = new System.Drawing.Point(13, 80);
            this.orginalText.Name = "orginalText";
            this.orginalText.Size = new System.Drawing.Size(283, 133);
            this.orginalText.TabIndex = 3;
            this.orginalText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orginal text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Encrypted text";
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(323, 80);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(46, 23);
            this.encrypt.TabIndex = 7;
            this.encrypt.Text = ">>";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(323, 109);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(46, 23);
            this.decrypt.TabIndex = 8;
            this.decrypt.Text = "<<";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(397, 81);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(283, 20);
            this.encryptedText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 221);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orginalText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.certPassword);
            this.Controls.Add(this.selectCertFile);
            this.Name = "Form1";
            this.Text = "X509 example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectCertFile;
        private System.Windows.Forms.MaskedTextBox certPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox orginalText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.OpenFileDialog openCertDialog;
        private System.Windows.Forms.TextBox encryptedText;
    }
}

