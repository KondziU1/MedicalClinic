namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    partial class FormAppointmentReschedule
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
            textBoxDoctorSpecEdit = new TextBox();
            label6 = new Label();
            comboBoxDateEdit = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelReschedule = new FontAwesome.Sharp.IconButton();
            btnAppointmentEdit = new FontAwesome.Sharp.IconButton();
            btnConfirmReschedule = new FontAwesome.Sharp.IconButton();
            comboBoxPatientPeselEdit = new ComboBox();
            comboBoxPatientNameEdit = new ComboBox();
            textBoxDoctorNameEdit = new TextBox();
            SuspendLayout();
            // 
            // textBoxDoctorSpecEdit
            // 
            textBoxDoctorSpecEdit.BackColor = Color.White;
            textBoxDoctorSpecEdit.Enabled = false;
            textBoxDoctorSpecEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoctorSpecEdit.Location = new Point(80, 372);
            textBoxDoctorSpecEdit.Margin = new Padding(3, 4, 3, 4);
            textBoxDoctorSpecEdit.Name = "textBoxDoctorSpecEdit";
            textBoxDoctorSpecEdit.ReadOnly = true;
            textBoxDoctorSpecEdit.Size = new Size(431, 34);
            textBoxDoctorSpecEdit.TabIndex = 65;
            textBoxDoctorSpecEdit.TextChanged += textBoxDoctorSpecEdit_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(89, 40);
            label6.Name = "label6";
            label6.Size = new Size(432, 36);
            label6.TabIndex = 63;
            label6.Text = "Reschedule appointment";
            label6.Click += label6_Click;
            // 
            // comboBoxDateEdit
            // 
            comboBoxDateEdit.BackColor = Color.White;
            comboBoxDateEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDateEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDateEdit.FormattingEnabled = true;
            comboBoxDateEdit.Location = new Point(80, 455);
            comboBoxDateEdit.Margin = new Padding(3, 4, 3, 4);
            comboBoxDateEdit.Name = "comboBoxDateEdit";
            comboBoxDateEdit.Size = new Size(431, 36);
            comboBoxDateEdit.TabIndex = 62;
            comboBoxDateEdit.SelectedIndexChanged += comboBoxDateEdit_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(80, 423);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 61;
            label5.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 340);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 60;
            label3.Text = "Doctor's specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 261);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 58;
            label4.Text = "Doctor's name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(82, 178);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 56;
            label2.Text = "Patient's pesel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 107);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 55;
            label1.Text = "Patient's name";
            // 
            // btnCancelReschedule
            // 
            btnCancelReschedule.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelReschedule.BackColor = Color.FromArgb(73, 80, 87);
            btnCancelReschedule.Cursor = Cursors.Hand;
            btnCancelReschedule.FlatAppearance.BorderSize = 0;
            btnCancelReschedule.FlatStyle = FlatStyle.Flat;
            btnCancelReschedule.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelReschedule.ForeColor = Color.White;
            btnCancelReschedule.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancelReschedule.IconColor = Color.White;
            btnCancelReschedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelReschedule.IconSize = 35;
            btnCancelReschedule.Location = new Point(59, 544);
            btnCancelReschedule.Margin = new Padding(3, 4, 3, 4);
            btnCancelReschedule.Name = "btnCancelReschedule";
            btnCancelReschedule.Size = new Size(229, 77);
            btnCancelReschedule.TabIndex = 70;
            btnCancelReschedule.Text = "Cancel";
            btnCancelReschedule.TextAlign = ContentAlignment.MiddleRight;
            btnCancelReschedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelReschedule.UseVisualStyleBackColor = false;
            btnCancelReschedule.Click += btnCancelReschedule_Click_1;
            // 
            // btnAppointmentEdit
            // 
            btnAppointmentEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAppointmentEdit.BackColor = Color.FromArgb(73, 80, 87);
            btnAppointmentEdit.Cursor = Cursors.Hand;
            btnAppointmentEdit.Enabled = false;
            btnAppointmentEdit.FlatAppearance.BorderSize = 0;
            btnAppointmentEdit.FlatStyle = FlatStyle.Flat;
            btnAppointmentEdit.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppointmentEdit.ForeColor = Color.White;
            btnAppointmentEdit.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAppointmentEdit.IconColor = Color.White;
            btnAppointmentEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAppointmentEdit.Location = new Point(296, 544);
            btnAppointmentEdit.Margin = new Padding(3, 4, 3, 4);
            btnAppointmentEdit.Name = "btnAppointmentEdit";
            btnAppointmentEdit.Size = new Size(229, 77);
            btnAppointmentEdit.TabIndex = 69;
            btnAppointmentEdit.Text = "Reschedule";
            btnAppointmentEdit.TextAlign = ContentAlignment.MiddleRight;
            btnAppointmentEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAppointmentEdit.UseVisualStyleBackColor = false;
            // 
            // btnConfirmReschedule
            // 
            btnConfirmReschedule.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmReschedule.BackColor = Color.FromArgb(73, 80, 87);
            btnConfirmReschedule.Cursor = Cursors.Hand;
            btnConfirmReschedule.Enabled = false;
            btnConfirmReschedule.FlatAppearance.BorderSize = 0;
            btnConfirmReschedule.FlatStyle = FlatStyle.Flat;
            btnConfirmReschedule.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmReschedule.ForeColor = Color.White;
            btnConfirmReschedule.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirmReschedule.IconColor = Color.White;
            btnConfirmReschedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmReschedule.Location = new Point(296, 544);
            btnConfirmReschedule.Margin = new Padding(3, 4, 3, 4);
            btnConfirmReschedule.Name = "btnConfirmReschedule";
            btnConfirmReschedule.Size = new Size(229, 77);
            btnConfirmReschedule.TabIndex = 71;
            btnConfirmReschedule.Text = "Confirm";
            btnConfirmReschedule.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmReschedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirmReschedule.UseVisualStyleBackColor = false;
            btnConfirmReschedule.Click += btnConfirmReschedule_Click;
            // 
            // comboBoxPatientPeselEdit
            // 
            comboBoxPatientPeselEdit.BackColor = SystemColors.Control;
            comboBoxPatientPeselEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientPeselEdit.Enabled = false;
            comboBoxPatientPeselEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientPeselEdit.FormattingEnabled = true;
            comboBoxPatientPeselEdit.Location = new Point(82, 210);
            comboBoxPatientPeselEdit.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientPeselEdit.Name = "comboBoxPatientPeselEdit";
            comboBoxPatientPeselEdit.Size = new Size(431, 36);
            comboBoxPatientPeselEdit.TabIndex = 73;
            comboBoxPatientPeselEdit.SelectedIndexChanged += comboBoxPatientPeselEdit_SelectedIndexChanged;
            // 
            // comboBoxPatientNameEdit
            // 
            comboBoxPatientNameEdit.BackColor = SystemColors.Control;
            comboBoxPatientNameEdit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientNameEdit.Enabled = false;
            comboBoxPatientNameEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientNameEdit.FormattingEnabled = true;
            comboBoxPatientNameEdit.Location = new Point(82, 138);
            comboBoxPatientNameEdit.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientNameEdit.Name = "comboBoxPatientNameEdit";
            comboBoxPatientNameEdit.Size = new Size(431, 36);
            comboBoxPatientNameEdit.TabIndex = 74;
            // 
            // textBoxDoctorNameEdit
            // 
            textBoxDoctorNameEdit.BackColor = Color.White;
            textBoxDoctorNameEdit.Enabled = false;
            textBoxDoctorNameEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoctorNameEdit.Location = new Point(80, 293);
            textBoxDoctorNameEdit.Margin = new Padding(3, 4, 3, 4);
            textBoxDoctorNameEdit.Name = "textBoxDoctorNameEdit";
            textBoxDoctorNameEdit.ReadOnly = true;
            textBoxDoctorNameEdit.Size = new Size(431, 34);
            textBoxDoctorNameEdit.TabIndex = 75;
            // 
            // FormAppointmentReschedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 648);
            Controls.Add(textBoxDoctorNameEdit);
            Controls.Add(comboBoxPatientNameEdit);
            Controls.Add(comboBoxPatientPeselEdit);
            Controls.Add(btnConfirmReschedule);
            Controls.Add(btnCancelReschedule);
            Controls.Add(btnAppointmentEdit);
            Controls.Add(textBoxDoctorSpecEdit);
            Controls.Add(label6);
            Controls.Add(comboBoxDateEdit);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAppointmentReschedule";
            Text = "Reschedule Appointment";
            Load += FormAppointmentReschedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDoctorSpecEdit;
        private Label label6;
        private ComboBox comboBoxDateEdit;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCancelReschedule;
        private FontAwesome.Sharp.IconButton btnAppointmentEdit;
        private FontAwesome.Sharp.IconButton btnConfirmReschedule;
        private ComboBox comboBoxPatientPeselEdit;
        private ComboBox comboBoxPatientNameEdit;
        private TextBox textBoxDoctorNameEdit;
    }
}