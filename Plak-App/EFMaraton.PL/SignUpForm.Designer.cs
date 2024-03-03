namespace EFMaraton.PL
{
    partial class SignUpForm
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
            txtUserName = new TextBox();
            txtUserPw = new TextBox();
            txtUserPwControl = new TextBox();
            btnSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(87, 39);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 0;
            // 
            // txtUserPw
            // 
            txtUserPw.Location = new Point(87, 81);
            txtUserPw.Name = "txtUserPw";
            txtUserPw.Size = new Size(100, 23);
            txtUserPw.TabIndex = 1;
            // 
            // txtUserPwControl
            // 
            txtUserPwControl.Location = new Point(95, 126);
            txtUserPwControl.Name = "txtUserPwControl";
            txtUserPwControl.Size = new Size(100, 23);
            txtUserPwControl.TabIndex = 2;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(68, 172);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 33);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "Kayit Ol";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "Kullanici Adi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Parola:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 6;
            label3.Text = "Parola Tekrar:";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(208, 248);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(txtUserPwControl);
            Controls.Add(txtUserPw);
            Controls.Add(txtUserName);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtUserPw;
        private TextBox txtUserPwControl;
        private Button btnSignUp;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}