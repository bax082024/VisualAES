﻿namespace VisualAES
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
            button1 = new Button();
            btnExit = new Button();
            label1 = new Label();
            lblTitle = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtPlainText
            // 
            txtPlainText.Location = new Point(137, 165);
            txtPlainText.Name = "txtPlainText";
            txtPlainText.Size = new Size(158, 23);
            txtPlainText.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(137, 221);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(159, 23);
            txtKey.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(97, 440);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Silver;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(394, 512);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 145);
            label1.Name = "label1";
            label1.Size = new Size(42, 17);
            label1.TabIndex = 4;
            label1.Text = "Text :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(162, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 50);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Visual AES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 201);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 7;
            label2.Text = "Key : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 312);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // VisualAESForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 615);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(button1);
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
        private Button button1;
        private Button btnExit;
        private Label label1;
        private Label lblTitle;
        private Label label2;
        private TextBox textBox1;
    }
}
