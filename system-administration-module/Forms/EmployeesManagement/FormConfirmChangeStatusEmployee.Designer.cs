namespace SystemAdministrationModule.Forms.EmployeesManagement
{
    partial class FormConfirmChangeStatusEmployee
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
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnNext = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            textBoxAdminPassword = new TextBox();
            label10 = new Label();
            SuspendLayout();
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
            btnCancel.Location = new Point(78, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 58);
            btnCancel.TabIndex = 27;
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
            btnNext.Location = new Point(299, 236);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(200, 58);
            btnNext.TabIndex = 26;
            btnNext.Text = "Confirm";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(78, 123);
            label8.Name = "label8";
            label8.Size = new Size(165, 21);
            label8.TabIndex = 22;
            label8.Text = "Enter admin password";
            // 
            // textBoxAdminPassword
            // 
            textBoxAdminPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAdminPassword.BackColor = Color.White;
            textBoxAdminPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdminPassword.Location = new Point(78, 147);
            textBoxAdminPassword.Name = "textBoxAdminPassword";
            textBoxAdminPassword.Size = new Size(421, 29);
            textBoxAdminPassword.TabIndex = 23;
            textBoxAdminPassword.UseSystemPasswordChar = true;
            textBoxAdminPassword.TextChanged += TextBoxAdminPassword_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(108, 35);
            label10.Name = "label10";
            label10.Size = new Size(364, 29);
            label10.TabIndex = 28;
            label10.Text = "Change employee's status";
            label10.Click += label10_Click;
            // 
            // FormConfirmChangeStatusEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 361);
            ControlBox = false;
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(textBoxAdminPassword);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormConfirmChangeStatusEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change employee's status";
            Load += FormConfirmDeActiveEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnNext;
        private Label label8;
        private TextBox textBoxAdminPassword;
        private Label label10;
    }
}