namespace SystemAdministrationModule.Forms
{
    partial class FormAddNewEmployee
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
            label1 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            label2 = new Label();
            textBoxPesel = new TextBox();
            label3 = new Label();
            dateTimePickerDateOfBirth = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            comboBoxRole = new ComboBox();
            textBoxAddress = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label7 = new Label();
            textBoxPhone = new TextBox();
            label8 = new Label();
            comboBoxSex = new ComboBox();
            label9 = new Label();
            btnNext = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            labelSpecialization = new Label();
            checkedListBoxSpecializations = new CheckedListBox();
            checkBoxUser = new CheckBox();
            textBoxPassword = new TextBox();
            label11 = new Label();
            textBoxLogin = new TextBox();
            label12 = new Label();
            textBoxPasswordConfirmation = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 106);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.White;
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(76, 130);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 29);
            textBoxFirstName.TabIndex = 1;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.White;
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(76, 203);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 29);
            textBoxLastName.TabIndex = 3;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(76, 177);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // textBoxPesel
            // 
            textBoxPesel.BackColor = Color.White;
            textBoxPesel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPesel.Location = new Point(76, 270);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(200, 29);
            textBoxPesel.TabIndex = 5;
            textBoxPesel.TextChanged += textBoxPesel_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 246);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "PESEL";
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateOfBirth.Format = DateTimePickerFormat.Short;
            dateTimePickerDateOfBirth.Location = new Point(76, 337);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(200, 29);
            dateTimePickerDateOfBirth.TabIndex = 6;
            dateTimePickerDateOfBirth.ValueChanged += dateTimePickerDateOfBirth_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(76, 313);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 7;
            label4.Text = "Date of birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(356, 246);
            label5.Name = "label5";
            label5.Size = new Size(41, 21);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.White;
            comboBoxRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(356, 270);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(200, 29);
            comboBoxRole.TabIndex = 9;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxAddress.BackColor = Color.White;
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(76, 478);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(200, 29);
            textBoxAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(76, 454);
            label6.Name = "label6";
            label6.Size = new Size(66, 21);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxEmail.BackColor = Color.White;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(356, 134);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 29);
            textBoxEmail.TabIndex = 13;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(356, 110);
            label7.Name = "label7";
            label7.Size = new Size(54, 21);
            label7.TabIndex = 12;
            label7.Text = "E-mail";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(356, 203);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(200, 29);
            textBoxPhone.TabIndex = 15;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(356, 179);
            label8.Name = "label8";
            label8.Size = new Size(54, 21);
            label8.TabIndex = 14;
            label8.Text = "Phone";
            // 
            // comboBoxSex
            // 
            comboBoxSex.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxSex.BackColor = Color.White;
            comboBoxSex.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Location = new Point(76, 405);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(200, 29);
            comboBoxSex.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(76, 381);
            label9.Name = "label9";
            label9.Size = new Size(34, 21);
            label9.TabIndex = 16;
            label9.Text = "Sex";
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
            btnNext.Location = new Point(356, 749);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(200, 58);
            btnNext.TabIndex = 18;
            btnNext.Text = "Add";
            btnNext.TextAlign = ContentAlignment.MiddleRight;
            btnNext.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
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
            btnCancel.Location = new Point(76, 749);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 58);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(175, 36);
            label10.Name = "label10";
            label10.Size = new Size(293, 29);
            label10.TabIndex = 20;
            label10.Text = "Add a new employee";
            // 
            // labelSpecialization
            // 
            labelSpecialization.Anchor = AnchorStyles.Top;
            labelSpecialization.AutoSize = true;
            labelSpecialization.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpecialization.Location = new Point(356, 313);
            labelSpecialization.Name = "labelSpecialization";
            labelSpecialization.Size = new Size(112, 21);
            labelSpecialization.TabIndex = 21;
            labelSpecialization.Text = "Specializations";
            // 
            // checkedListBoxSpecializations
            // 
            checkedListBoxSpecializations.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxSpecializations.FormattingEnabled = true;
            checkedListBoxSpecializations.Location = new Point(356, 337);
            checkedListBoxSpecializations.Name = "checkedListBoxSpecializations";
            checkedListBoxSpecializations.Size = new Size(200, 172);
            checkedListBoxSpecializations.TabIndex = 23;
            // 
            // checkBoxUser
            // 
            checkBoxUser.AutoSize = true;
            checkBoxUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxUser.Location = new Point(76, 532);
            checkBoxUser.Name = "checkBoxUser";
            checkBoxUser.Size = new Size(278, 25);
            checkBoxUser.TabIndex = 24;
            checkBoxUser.Text = "Do you want add user to employee?";
            checkBoxUser.UseVisualStyleBackColor = true;
            checkBoxUser.CheckedChanged += checkBoxUser_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(76, 669);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(200, 29);
            textBoxPassword.TabIndex = 33;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(76, 645);
            label11.Name = "label11";
            label11.Size = new Size(76, 21);
            label11.TabIndex = 32;
            label11.Text = "Password";
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(76, 599);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(200, 29);
            textBoxLogin.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(76, 575);
            label12.Name = "label12";
            label12.Size = new Size(49, 21);
            label12.TabIndex = 30;
            label12.Text = "Login";
            // 
            // textBoxPasswordConfirmation
            // 
            textBoxPasswordConfirmation.BackColor = Color.White;
            textBoxPasswordConfirmation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordConfirmation.Location = new Point(356, 599);
            textBoxPasswordConfirmation.Name = "textBoxPasswordConfirmation";
            textBoxPasswordConfirmation.Size = new Size(200, 29);
            textBoxPasswordConfirmation.TabIndex = 35;
            textBoxPasswordConfirmation.UseSystemPasswordChar = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(356, 575);
            label13.Name = "label13";
            label13.Size = new Size(169, 21);
            label13.TabIndex = 34;
            label13.Text = "Password confirmation";
            // 
            // FormAddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(632, 853);
            ControlBox = false;
            Controls.Add(textBoxPasswordConfirmation);
            Controls.Add(label13);
            Controls.Add(textBoxPassword);
            Controls.Add(label11);
            Controls.Add(textBoxLogin);
            Controls.Add(label12);
            Controls.Add(checkBoxUser);
            Controls.Add(checkedListBoxSpecializations);
            Controls.Add(labelSpecialization);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnNext);
            Controls.Add(comboBoxSex);
            Controls.Add(label9);
            Controls.Add(textBoxPhone);
            Controls.Add(label8);
            Controls.Add(textBoxEmail);
            Controls.Add(label7);
            Controls.Add(textBoxAddress);
            Controls.Add(label6);
            Controls.Add(comboBoxRole);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePickerDateOfBirth);
            Controls.Add(textBoxPesel);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(label2);
            Controls.Add(textBoxFirstName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormAddNewEmployee";
            Text = "Add a new employee";
            Load += FormAddNewEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label label2;
        private TextBox textBoxPesel;
        private Label label3;
        private DateTimePicker dateTimePickerDateOfBirth;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxRole;
        private TextBox textBoxAddress;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label7;
        private TextBox textBoxPhone;
        private Label label8;
        private ComboBox comboBoxSex;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Label label10;
        private Label labelSpecialization;
        private CheckedListBox checkedListBoxSpecializations;
        private CheckBox checkBoxUser;
        private TextBox textBoxPassword;
        private Label label11;
        private TextBox textBoxLogin;
        private Label label12;
        private TextBox textBoxPasswordConfirmation;
        private Label label13;
    }
}