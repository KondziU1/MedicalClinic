namespace SystemAdministrationModule.Forms.Auth
{
    partial class FormForgotPasswordCode
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
            textBoxCode = new TextBox();
            emailTextBox = new Label();
            btnOk = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(102, 33);
            label10.Name = "label10";
            label10.Size = new Size(240, 29);
            label10.TabIndex = 22;
            label10.Text = "Forgot Password";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(102, 115);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(258, 23);
            textBoxCode.TabIndex = 31;
            textBoxCode.TextChanged += textBoxEmail_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.AutoSize = true;
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(102, 91);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(126, 21);
            emailTextBox.TabIndex = 26;
            emailTextBox.Text = "Code from email";
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
            btnOk.Location = new Point(234, 198);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(126, 58);
            btnOk.TabIndex = 30;
            btnOk.Text = "Ok";
            btnOk.TextAlign = ContentAlignment.MiddleRight;
            btnOk.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.FromArgb(73, 80, 87);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 35;
            btnCancel.Location = new Point(102, 198);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 58);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormForgotPasswordCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 280);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(textBoxCode);
            Controls.Add(emailTextBox);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormForgotPasswordCode";
            Text = "Login";
            FormClosing += FormLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox textBoxCode;
        private Label emailTextBox;
        private FontAwesome.Sharp.IconButton btnOk;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}