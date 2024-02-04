namespace SystemAdministrationModule.Forms.UserManagement
{
    partial class FormChangeUserPassword
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
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnNext = new FontAwesome.Sharp.IconButton();
            textBoxPassword = new TextBox();
            label8 = new Label();
            textBoxPasswordConfirmation = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(120, 55);
            label10.Name = "label10";
            label10.Size = new Size(340, 29);
            label10.TabIndex = 38;
            label10.Text = "Change user's password";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.BackColor = Color.FromArgb(73, 80, 87);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.IconSize = 35;
            btnCancel.Location = new Point(72, 299);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 58);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.FromArgb(73, 80, 87);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnNext.IconColor = Color.White;
            btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNext.Location = new Point(293, 299);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(200, 58);
            btnNext.TabIndex = 36;
            btnNext.Text = "Confirm";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(72, 144);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(421, 29);
            textBoxPassword.TabIndex = 35;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(72, 120);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 34;
            label8.Text = "Password";
            // 
            // textBoxPasswordConfirmation
            // 
            textBoxPasswordConfirmation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPasswordConfirmation.BackColor = Color.White;
            textBoxPasswordConfirmation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordConfirmation.Location = new Point(72, 218);
            textBoxPasswordConfirmation.Name = "textBoxPasswordConfirmation";
            textBoxPasswordConfirmation.Size = new Size(421, 29);
            textBoxPasswordConfirmation.TabIndex = 40;
            textBoxPasswordConfirmation.UseSystemPasswordChar = true;
            textBoxPasswordConfirmation.TextChanged += textBoxPasswordConfirmation_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(72, 194);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 39;
            label1.Text = "Password confirmation";
            // 
            // FormChangeUserPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 409);
            ControlBox = false;
            Controls.Add(textBoxPasswordConfirmation);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(textBoxPassword);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormChangeUserPassword";
            Text = "Change user password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnNext;
        private TextBox textBoxPassword;
        private Label label8;
        private TextBox textBoxPasswordConfirmation;
        private Label label1;
    }
}