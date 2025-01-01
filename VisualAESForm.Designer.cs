namespace VisualAES
{
    partial class VisualAESForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPlainText = new TextBox();
            txtKey = new TextBox();
            btnEncrypt = new Button();
            btnExit = new Button();
            label1 = new Label();
            lblTitle = new Label();
            label2 = new Label();
            txtEncryptedText = new TextBox();
            label3 = new Label();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // txtPlainText
            // 
            txtPlainText.BackColor = SystemColors.Info;
            txtPlainText.Location = new Point(150, 172);
            txtPlainText.Name = "txtPlainText";
            txtPlainText.Size = new Size(158, 23);
            txtPlainText.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.BackColor = SystemColors.Info;
            txtKey.Location = new Point(149, 232);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(159, 23);
            txtKey.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.LightGreen;
            btnEncrypt.FlatStyle = FlatStyle.Popup;
            btnEncrypt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.Location = new Point(119, 351);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(96, 35);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(366, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(80, 30);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 152);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 4;
            label1.Text = "Text :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(130, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 50);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Visual AES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 212);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 7;
            label2.Text = "Key : ";
            // 
            // txtEncryptedText
            // 
            txtEncryptedText.BackColor = SystemColors.Info;
            txtEncryptedText.Location = new Point(148, 291);
            txtEncryptedText.Name = "txtEncryptedText";
            txtEncryptedText.ReadOnly = true;
            txtEncryptedText.Size = new Size(158, 23);
            txtEncryptedText.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 271);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 9;
            label3.Text = "Encrypted Text : ";
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.LightBlue;
            btnDecrypt.FlatStyle = FlatStyle.Popup;
            btnDecrypt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.Location = new Point(238, 351);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(96, 35);
            btnDecrypt.TabIndex = 10;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // VisualAESForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(472, 497);
            Controls.Add(btnDecrypt);
            Controls.Add(label3);
            Controls.Add(txtEncryptedText);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnEncrypt);
            Controls.Add(txtKey);
            Controls.Add(txtPlainText);
            Name = "VisualAESForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visual AES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlainText;
        private TextBox txtKey;
        private Button btnEncrypt;
        private Button btnExit;
        private Label label1;
        private Label lblTitle;
        private Label label2;
        private TextBox txtEncryptedText;
        private Label label3;
        private Button btnDecrypt;
    }
}
