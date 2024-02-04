namespace SystemAdministrationModule.Forms.Auth
{
    partial class FormForgotPassword
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
            textBoxEmail = new TextBox();
            emailTextBox = new Label();
            btnLogin = new FontAwesome.Sharp.IconButton();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(102, 32);
            label10.Name = "label10";
            label10.Size = new Size(240, 29);
            label10.TabIndex = 22;
            label10.Text = "Forgot Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(102, 131);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(240, 23);
            textBoxEmail.TabIndex = 31;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.AutoSize = true;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(102, 107);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(48, 21);
            emailTextBox.TabIndex = 26;
            emailTextBox.Text = "Email";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(73, 80, 87);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            btnLogin.IconColor = Color.White;
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.IconSize = 35;
            btnLogin.Location = new Point(148, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 58);
            btnLogin.TabIndex = 30;
            btnLogin.Text = "Ok";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(146, 169);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 15);
            linkLabel1.TabIndex = 34;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I already have the code";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 280);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(textBoxEmail);
            Controls.Add(emailTextBox);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormForgotPassword";
            Text = "Login";
            FormClosing += FormLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox textBoxEmail;
        private Label emailTextBox;
        private FontAwesome.Sharp.IconButton btnLogin;
        private LinkLabel linkLabel1;
    }
}