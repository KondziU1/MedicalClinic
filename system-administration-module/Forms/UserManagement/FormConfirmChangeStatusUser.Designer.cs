namespace SystemAdministrationModule.Forms.UserManagement
{
    partial class FormConfirmChangeStatusUser
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
            textBoxAdminPassword = new TextBox();
            label8 = new Label();
            checkBoxSetEmployeeStatus = new CheckBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(150, 54);
            label10.Name = "label10";
            label10.Size = new Size(293, 29);
            label10.TabIndex = 33;
            label10.Text = "Change user's status";
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
            btnCancel.Location = new Point(84, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 58);
            btnCancel.TabIndex = 32;
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
            btnNext.Location = new Point(305, 286);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(200, 58);
            btnNext.TabIndex = 31;
            btnNext.Text = "Confirm";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // textBoxAdminPassword
            // 
            textBoxAdminPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAdminPassword.BackColor = Color.White;
            textBoxAdminPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAdminPassword.Location = new Point(84, 164);
            textBoxAdminPassword.Name = "textBoxAdminPassword";
            textBoxAdminPassword.Size = new Size(421, 29);
            textBoxAdminPassword.TabIndex = 30;
            textBoxAdminPassword.UseSystemPasswordChar = true;
            textBoxAdminPassword.TextChanged += textBoxAdminPassword_TextChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(84, 140);
            label8.Name = "label8";
            label8.Size = new Size(165, 21);
            label8.TabIndex = 29;
            label8.Text = "Enter admin password";
            // 
            // checkBoxSetEmployeeStatus
            // 
            checkBoxSetEmployeeStatus.AutoSize = true;
            checkBoxSetEmployeeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSetEmployeeStatus.Location = new Point(84, 224);
            checkBoxSetEmployeeStatus.Name = "checkBoxSetEmployeeStatus";
            checkBoxSetEmployeeStatus.Size = new Size(356, 25);
            checkBoxSetEmployeeStatus.TabIndex = 34;
            checkBoxSetEmployeeStatus.Text = "Do you also want to change employee's status?";
            checkBoxSetEmployeeStatus.UseVisualStyleBackColor = true;
            // 
            // FormConfirmChangeStatusUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 398);
            ControlBox = false;
            Controls.Add(checkBoxSetEmployeeStatus);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(textBoxAdminPassword);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormConfirmChangeStatusUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change user's status";
            Load += FormConfirmChangeStatusUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnNext;
        private TextBox textBoxAdminPassword;
        private Label label8;
        private CheckBox checkBoxSetEmployeeStatus;
    }
}