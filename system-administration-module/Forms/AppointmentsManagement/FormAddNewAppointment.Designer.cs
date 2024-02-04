namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    partial class FormAddNewAppointment
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
            components = new System.ComponentModel.Container();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            label2 = new Label();
            comboBoxPatientsPesel = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxDate = new ComboBox();
            label6 = new Label();
            textBoxPatientName = new TextBox();
            comboBoxDoctorsName = new ComboBox();
            textBoxDoctorSpec = new TextBox();
            textBoxPesel = new TextBox();
            label7 = new Label();
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
            btnCancel.Location = new Point(59, 640);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(229, 77);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(73, 80, 87);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Enabled = false;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(335, 640);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(229, 77);
            btnAdd.TabIndex = 37;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 216);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 33;
            label1.Text = "Patient's name";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 90);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 43;
            label2.Text = "Patient's PESEL";
            // 
            // comboBoxPatientsPesel
            // 
            comboBoxPatientsPesel.BackColor = Color.White;
            comboBoxPatientsPesel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientsPesel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientsPesel.FormattingEnabled = true;
            comboBoxPatientsPesel.Location = new Point(79, 170);
            comboBoxPatientsPesel.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientsPesel.Name = "comboBoxPatientsPesel";
            comboBoxPatientsPesel.Size = new Size(431, 36);
            comboBoxPatientsPesel.TabIndex = 44;
            comboBoxPatientsPesel.SelectedIndexChanged += comboBoxPatientsPesel_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 416);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 47;
            label3.Text = "Doctor's specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 319);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 45;
            label4.Text = "Doctor's name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 507);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 49;
            label5.Text = "Date";
            // 
            // comboBoxDate
            // 
            comboBoxDate.BackColor = Color.White;
            comboBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(79, 539);
            comboBoxDate.Margin = new Padding(3, 4, 3, 4);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(431, 36);
            comboBoxDate.TabIndex = 50;
            comboBoxDate.SelectedIndexChanged += comboBoxDate_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(108, 32);
            label6.Name = "label6";
            label6.Size = new Size(415, 36);
            label6.TabIndex = 52;
            label6.Text = "Add a new appointment";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Enabled = false;
            textBoxPatientName.Location = new Point(80, 259);
            textBoxPatientName.Margin = new Padding(3, 4, 3, 4);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(431, 27);
            textBoxPatientName.TabIndex = 53;
            // 
            // comboBoxDoctorsName
            // 
            comboBoxDoctorsName.BackColor = Color.White;
            comboBoxDoctorsName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctorsName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDoctorsName.FormattingEnabled = true;
            comboBoxDoctorsName.Location = new Point(79, 351);
            comboBoxDoctorsName.Margin = new Padding(3, 4, 3, 4);
            comboBoxDoctorsName.Name = "comboBoxDoctorsName";
            comboBoxDoctorsName.Size = new Size(431, 36);
            comboBoxDoctorsName.TabIndex = 46;
            comboBoxDoctorsName.SelectedIndexChanged += comboBoxDoctorsName_SelectedIndexChanged;
            // 
            // textBoxDoctorSpec
            // 
            textBoxDoctorSpec.Enabled = false;
            textBoxDoctorSpec.Location = new Point(80, 448);
            textBoxDoctorSpec.Margin = new Padding(3, 4, 3, 4);
            textBoxDoctorSpec.Name = "textBoxDoctorSpec";
            textBoxDoctorSpec.ReadOnly = true;
            textBoxDoctorSpec.Size = new Size(431, 27);
            textBoxDoctorSpec.TabIndex = 54;
            // 
            // textBoxPesel
            // 
            textBoxPesel.Location = new Point(256, 131);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(255, 27);
            textBoxPesel.TabIndex = 55;
            textBoxPesel.TextChanged += textBox_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 134);
            label7.Name = "label7";
            label7.Size = new Size(170, 20);
            label7.TabIndex = 56;
            label7.Text = "Filter the patient's PESEL";
            // 
            // FormAddNewAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 734);
            Controls.Add(label7);
            Controls.Add(textBoxPesel);
            Controls.Add(textBoxDoctorSpec);
            Controls.Add(textBoxPatientName);
            Controls.Add(label6);
            Controls.Add(comboBoxDate);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(comboBoxDoctorsName);
            Controls.Add(label4);
            Controls.Add(comboBoxPatientsPesel);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAddNewAppointment";
            Text = "FormAddNewAppointment";
            Load += FormAddNewAppointment_Load;
            MouseMove += FormAddNewAppointment_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAdd;
        private Label label1;
        private NotifyIcon notifyIcon1;
        private Label label2;
        public ComboBox comboBoxPatientsPesel;
        private Label label3;
        private Label label4;
        private Label label5;
        public ComboBox comboBoxDate;
        private Label label6;
        private TextBox textBoxPatientName;
        public ComboBox comboBoxDoctorsName;
        private TextBox textBoxDoctorSpec;
        private TextBox textBoxPesel;
        private Label label7;
    }
}