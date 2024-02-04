namespace SystemAdministrationModule.Forms.EmployeesManagement
{
    partial class FormEmployeeDetails
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
            labelTitle = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxPesel = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxCorrespondenceAddress = new TextBox();
            label8 = new Label();
            textBoxEmail = new TextBox();
            label9 = new Label();
            textBoxPhone = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnConfirm = new FontAwesome.Sharp.IconButton();
            comboBoxRole = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            comboBoxSex = new ComboBox();
            comboBoxActiveStatus = new ComboBox();
            checkedListBoxSpecializations = new CheckedListBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(284, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(241, 29);
            labelTitle.TabIndex = 23;
            labelTitle.Text = "Employee details";
            // 
            // textBoxId
            // 
            textBoxId.BackColor = Color.White;
            textBoxId.Enabled = false;
            textBoxId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(77, 120);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(197, 29);
            textBoxId.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 30;
            label2.Text = "Employee ID";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.White;
            textBoxFirstName.Enabled = false;
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(77, 182);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(197, 29);
            textBoxFirstName.TabIndex = 33;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 158);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 32;
            label1.Text = "First name";
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.White;
            textBoxLastName.Enabled = false;
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(77, 245);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(197, 29);
            textBoxLastName.TabIndex = 35;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 221);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 34;
            label3.Text = "Last name";
            // 
            // textBoxPesel
            // 
            textBoxPesel.BackColor = Color.White;
            textBoxPesel.Enabled = false;
            textBoxPesel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesel.Location = new Point(77, 307);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(197, 29);
            textBoxPesel.TabIndex = 37;
            textBoxPesel.TextChanged += textBoxPesel_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(77, 283);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 36;
            label4.Text = "PESEL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 351);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 38;
            label5.Text = "Date of birth";
            // 
            // textBoxCorrespondenceAddress
            // 
            textBoxCorrespondenceAddress.BackColor = Color.White;
            textBoxCorrespondenceAddress.Enabled = false;
            textBoxCorrespondenceAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorrespondenceAddress.Location = new Point(312, 120);
            textBoxCorrespondenceAddress.Name = "textBoxCorrespondenceAddress";
            textBoxCorrespondenceAddress.Size = new Size(197, 29);
            textBoxCorrespondenceAddress.TabIndex = 45;
            textBoxCorrespondenceAddress.TextChanged += textBoxCorrespondenceAddress_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(312, 96);
            label8.Name = "label8";
            label8.Size = new Size(182, 21);
            label8.TabIndex = 44;
            label8.Text = "Correspondence address";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(312, 180);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(197, 29);
            textBoxEmail.TabIndex = 47;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(312, 156);
            label9.Name = "label9";
            label9.Size = new Size(48, 21);
            label9.TabIndex = 46;
            label9.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.Enabled = false;
            textBoxPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(312, 243);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(197, 29);
            textBoxPhone.TabIndex = 49;
            textBoxPhone.TextChanged += textBoxPhone_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(312, 219);
            label11.Name = "label11";
            label11.Size = new Size(113, 21);
            label11.TabIndex = 48;
            label11.Text = "Phone number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(312, 283);
            label12.Name = "label12";
            label12.Size = new Size(34, 21);
            label12.TabIndex = 50;
            label12.Text = "Sex";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(312, 351);
            label13.Name = "label13";
            label13.Size = new Size(97, 21);
            label13.TabIndex = 52;
            label13.Text = "Active status";
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
            btnEdit.Location = new Point(456, 459);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(283, 58);
            btnEdit.TabIndex = 59;
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            btnCancel.Location = new Point(77, 459);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(283, 58);
            btnCancel.TabIndex = 60;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnConfirm.Location = new Point(456, 459);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(283, 58);
            btnConfirm.TabIndex = 61;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextAlign = ContentAlignment.MiddleRight;
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Visible = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxRole.BackColor = Color.White;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Enabled = false;
            comboBoxRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(542, 120);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(197, 29);
            comboBoxRole.TabIndex = 93;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(542, 159);
            label15.Name = "label15";
            label15.Size = new Size(112, 21);
            label15.TabIndex = 92;
            label15.Text = "Specializations";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(542, 96);
            label14.Name = "label14";
            label14.Size = new Size(41, 21);
            label14.TabIndex = 91;
            label14.Text = "Role";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDateOfBirth.Enabled = false;
            dateTimePickerDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfBirth.Location = new Point(77, 375);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(197, 29);
            dateTimePickerDateOfBirth.TabIndex = 95;
            dateTimePickerDateOfBirth.ValueChanged += dateTimePickerDateOfBirth_ValueChanged;
            // 
            // comboBoxSex
            // 
            comboBoxSex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSex.BackColor = Color.White;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Enabled = false;
            comboBoxSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(312, 307);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(197, 29);
            comboBoxSex.TabIndex = 96;
            comboBoxSex.SelectedIndexChanged += comboBoxSex_SelectedIndexChanged;
            // 
            // comboBoxActiveStatus
            // 
            comboBoxActiveStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxActiveStatus.BackColor = Color.White;
            comboBoxActiveStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActiveStatus.Enabled = false;
            comboBoxActiveStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActiveStatus.FormattingEnabled = true;
            comboBoxActiveStatus.Location = new Point(312, 375);
            comboBoxActiveStatus.Name = "comboBoxActiveStatus";
            comboBoxActiveStatus.Size = new Size(197, 29);
            comboBoxActiveStatus.TabIndex = 97;
            comboBoxActiveStatus.SelectedIndexChanged += comboBoxActiveStatus_SelectedIndexChanged;
            // 
            // checkedListBoxSpecializations
            // 
            checkedListBoxSpecializations.Enabled = false;
            checkedListBoxSpecializations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxSpecializations.FormattingEnabled = true;
            checkedListBoxSpecializations.Location = new Point(542, 180);
            checkedListBoxSpecializations.Name = "checkedListBoxSpecializations";
            checkedListBoxSpecializations.Size = new Size(197, 220);
            checkedListBoxSpecializations.TabIndex = 98;
            // 
            // FormEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 582);
            ControlBox = false;
            Controls.Add(checkedListBoxSpecializations);
            Controls.Add(comboBoxActiveStatus);
            Controls.Add(comboBoxSex);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(comboBoxRole);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBoxPhone);
            Controls.Add(label11);
            Controls.Add(textBoxEmail);
            Controls.Add(label9);
            Controls.Add(textBoxCorrespondenceAddress);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(textBoxPesel);
            Controls.Add(label4);
            Controls.Add(textBoxLastName);
            Controls.Add(label3);
            Controls.Add(textBoxFirstName);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormEmployeeDetails";
            Text = "Employee details";
            Load += FormEmployeeDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxFirstName;
        private Label label1;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxPesel;
        private Label label4;
        private Label label5;
        private TextBox textBoxCorrespondenceAddress;
        private Label label8;
        private TextBox textBoxEmail;
        private Label label9;
        private TextBox textBoxPhone;
        private Label label11;
        private Label label12;
        private Label label13;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnConfirm;
        private ComboBox comboBoxRole;
        private Label label15;
        private Label label14;
        private DateTimePicker dateTimePickerDateOfBirth;
        private ComboBox comboBoxSex;
        private ComboBox comboBoxActiveStatus;
        private CheckedListBox checkedListBoxSpecializations;
    }
}