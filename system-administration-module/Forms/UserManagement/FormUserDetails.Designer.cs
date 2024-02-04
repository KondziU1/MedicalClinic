namespace SystemAdministrationModule.Forms.UserManagement
{
    partial class FormUserDetails
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
            btnConfirm = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            labelTitle = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxLogin = new TextBox();
            label1 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            comboBoxActiveStatus = new ComboBox();
            label13 = new Label();
            buttonChangePassword = new Button();
            comboBoxEmployees = new ComboBox();
            label6 = new Label();
            checkBoxSetEmployeeStatus = new CheckBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(73, 80, 87);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirm.IconColor = Color.White;
            btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirm.Location = new Point(416, 384);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(283, 58);
            btnConfirm.TabIndex = 64;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextAlign = ContentAlignment.MiddleRight;
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Visible = false;
            btnConfirm.Click += btnConfirm_Click;
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
            btnCancel.Location = new Point(65, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(283, 58);
            btnCancel.TabIndex = 63;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(73, 80, 87);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.IconSize = 35;
            btnEdit.Location = new Point(416, 384);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(283, 58);
            btnEdit.TabIndex = 62;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(308, 34);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(172, 29);
            labelTitle.TabIndex = 65;
            labelTitle.Text = "User details";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.White;
            textBoxId.Enabled = false;
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(65, 109);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(283, 29);
            textBoxId.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 85);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 66;
            label2.Text = "User ID";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.Enabled = false;
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(65, 183);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(283, 29);
            textBoxLogin.TabIndex = 69;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 159);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 68;
            label1.Text = "Login";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(416, 183);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(283, 29);
            textBoxEmail.TabIndex = 71;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(416, 159);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 70;
            label3.Text = "Email";
            // 
            // comboBoxActiveStatus
            // 
            comboBoxActiveStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxActiveStatus.BackColor = Color.White;
            comboBoxActiveStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActiveStatus.Enabled = false;
            comboBoxActiveStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActiveStatus.FormattingEnabled = true;
            comboBoxActiveStatus.Location = new Point(65, 259);
            comboBoxActiveStatus.Name = "comboBoxActiveStatus";
            comboBoxActiveStatus.Size = new Size(283, 29);
            comboBoxActiveStatus.TabIndex = 99;
            comboBoxActiveStatus.SelectedIndexChanged += comboBoxActiveStatus_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(65, 235);
            label13.Name = "label13";
            label13.Size = new Size(97, 21);
            label13.TabIndex = 98;
            label13.Text = "Active status";
            // 
            // buttonChangePassword
            // 
            buttonChangePassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangePassword.Location = new Point(416, 259);
            buttonChangePassword.Name = "buttonChangePassword";
            buttonChangePassword.Size = new Size(283, 29);
            buttonChangePassword.TabIndex = 106;
            buttonChangePassword.Text = "Change password";
            buttonChangePassword.UseVisualStyleBackColor = true;
            buttonChangePassword.Visible = false;
            buttonChangePassword.Click += buttonChangePassword_Click;
            // 
            // comboBoxEmployees
            // 
            comboBoxEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxEmployees.BackColor = Color.White;
            comboBoxEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployees.Enabled = false;
            comboBoxEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEmployees.FormattingEnabled = true;
            comboBoxEmployees.Location = new Point(416, 109);
            comboBoxEmployees.Name = "comboBoxEmployees";
            comboBoxEmployees.Size = new Size(283, 29);
            comboBoxEmployees.TabIndex = 108;
            comboBoxEmployees.SelectedIndexChanged += comboBoxEmployees_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(421, 85);
            label6.Name = "label6";
            label6.Size = new Size(78, 21);
            label6.TabIndex = 107;
            label6.Text = "Employee";
            // 
            // checkBoxSetEmployeeStatus
            // 
            checkBoxSetEmployeeStatus.AutoSize = true;
            checkBoxSetEmployeeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxSetEmployeeStatus.Location = new Point(65, 318);
            checkBoxSetEmployeeStatus.Name = "checkBoxSetEmployeeStatus";
            checkBoxSetEmployeeStatus.Size = new Size(356, 25);
            checkBoxSetEmployeeStatus.TabIndex = 109;
            checkBoxSetEmployeeStatus.Text = "Do you also want to change employee's status?";
            checkBoxSetEmployeeStatus.UseVisualStyleBackColor = true;
            checkBoxSetEmployeeStatus.Visible = false;
            // 
            // FormUserDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 494);
            ControlBox = false;
            Controls.Add(checkBoxSetEmployeeStatus);
            Controls.Add(comboBoxEmployees);
            Controls.Add(label6);
            Controls.Add(buttonChangePassword);
            Controls.Add(comboBoxActiveStatus);
            Controls.Add(label13);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormUserDetails";
            Text = "User details";
            Load += FormUserDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnConfirm;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnEdit;
        private Label labelTitle;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxLogin;
        private Label label1;
        private TextBox textBoxEmail;
        private Label label3;
        private ComboBox comboBoxActiveStatus;
        private Label label13;
        private Button buttonChangePassword;
        private ComboBox comboBoxEmployees;
        private Label label6;
        private CheckBox checkBoxSetEmployeeStatus;
    }
}