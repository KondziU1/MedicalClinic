namespace SystemAdministrationModule.Forms.Auth
{
    partial class FormForgotPasswordNew
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
            label10 = new Label();
            textBoxNewPassword = new TextBox();
            loginLabel = new Label();
            btnOk = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            textBoxConfirmPassword = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(102, 9);
            label10.Name = "label10";
            label10.Size = new Size(240, 29);
            label10.TabIndex = 22;
            label10.Text = "Forgot Password";
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(102, 113);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(258, 23);
            textBoxNewPassword.TabIndex = 31;
            textBoxNewPassword.UseSystemPasswordChar = true;
            textBoxNewPassword.TextChanged += textBoxNewPassword_TextChanged;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginLabel.Location = new Point(102, 49);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(56, 21);
            loginLabel.TabIndex = 26;
            loginLabel.Text = "Login: ";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.None;
            btnOk.BackColor = Color.FromArgb(73, 80, 87);
            btnOk.Cursor = Cursors.Hand;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            btnOk.IconColor = Color.White;
            btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOk.IconSize = 35;
            btnOk.Location = new Point(234, 210);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(126, 58);
            btnOk.TabIndex = 30;
            btnOk.Text = "Ok";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 89);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 35;
            label1.Text = "New password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 157);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 37;
            label2.Text = "Confirm password ";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(102, 181);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(258, 23);
            textBoxConfirmPassword.TabIndex = 36;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.TextChanged += textBoxConfirmPassword_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.FromArgb(73, 80, 87);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(102, 210);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(126, 58);
            iconButton1.TabIndex = 38;
            iconButton1.Text = "Cancel";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // FormForgotPasswordNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 280);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Controls.Add(textBoxNewPassword);
            Controls.Add(loginLabel);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormForgotPasswordNew";
            Text = "Login";
            FormClosing += FormLogin_FormClosing;
            Load += FormForgotPasswordNew_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox textBoxNewPassword;
        private Label loginLabel;
        private FontAwesome.Sharp.IconButton btnOk;
        private Label label1;
        private Label label2;
        private TextBox textBoxConfirmPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}