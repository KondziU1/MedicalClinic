namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    partial class FormAppointmentDetails
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
            textBoxDoctorNameDetails = new TextBox();
            comboBoxPatientNameDetails = new ComboBox();
            comboBoxPatientPeselDetails = new ComboBox();
            btnOkDetails = new FontAwesome.Sharp.IconButton();
            textBoxDoctorSpecDetails = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDateDetails = new TextBox();
            SuspendLayout();
            // 
            // textBoxDoctorNameDetails
            // 
            textBoxDoctorNameDetails.BackColor = Color.White;
            textBoxDoctorNameDetails.Enabled = false;
            textBoxDoctorNameDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoctorNameDetails.Location = new Point(85, 293);
            textBoxDoctorNameDetails.Margin = new Padding(3, 4, 3, 4);
            textBoxDoctorNameDetails.Name = "textBoxDoctorNameDetails";
            textBoxDoctorNameDetails.ReadOnly = true;
            textBoxDoctorNameDetails.Size = new Size(431, 34);
            textBoxDoctorNameDetails.TabIndex = 89;
            // 
            // comboBoxPatientNameDetails
            // 
            comboBoxPatientNameDetails.BackColor = SystemColors.Control;
            comboBoxPatientNameDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientNameDetails.Enabled = false;
            comboBoxPatientNameDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientNameDetails.FormattingEnabled = true;
            comboBoxPatientNameDetails.Location = new Point(87, 138);
            comboBoxPatientNameDetails.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientNameDetails.Name = "comboBoxPatientNameDetails";
            comboBoxPatientNameDetails.Size = new Size(431, 36);
            comboBoxPatientNameDetails.TabIndex = 88;
            // 
            // comboBoxPatientPeselDetails
            // 
            comboBoxPatientPeselDetails.BackColor = SystemColors.Control;
            comboBoxPatientPeselDetails.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPatientPeselDetails.Enabled = false;
            comboBoxPatientPeselDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPatientPeselDetails.FormattingEnabled = true;
            comboBoxPatientPeselDetails.Location = new Point(87, 210);
            comboBoxPatientPeselDetails.Margin = new Padding(3, 4, 3, 4);
            comboBoxPatientPeselDetails.Name = "comboBoxPatientPeselDetails";
            comboBoxPatientPeselDetails.Size = new Size(431, 36);
            comboBoxPatientPeselDetails.TabIndex = 87;
            // 
            // btnOkDetails
            // 
            btnOkDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOkDetails.BackColor = Color.FromArgb(73, 80, 87);
            btnOkDetails.Cursor = Cursors.Hand;
            btnOkDetails.FlatAppearance.BorderSize = 0;
            btnOkDetails.FlatStyle = FlatStyle.Flat;
            btnOkDetails.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkDetails.ForeColor = Color.White;
            btnOkDetails.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOkDetails.IconColor = Color.White;
            btnOkDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOkDetails.Location = new Point(161, 538);
            btnOkDetails.Margin = new Padding(3, 4, 3, 4);
            btnOkDetails.Name = "btnOkDetails";
            btnOkDetails.Size = new Size(229, 77);
            btnOkDetails.TabIndex = 86;
            btnOkDetails.Text = "OK";
            btnOkDetails.TextAlign = ContentAlignment.MiddleRight;
            btnOkDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOkDetails.UseVisualStyleBackColor = false;
            btnOkDetails.Click += btnOkDetails_Click;
            // 
            // textBoxDoctorSpecDetails
            // 
            textBoxDoctorSpecDetails.BackColor = Color.White;
            textBoxDoctorSpecDetails.Enabled = false;
            textBoxDoctorSpecDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDoctorSpecDetails.Location = new Point(85, 372);
            textBoxDoctorSpecDetails.Margin = new Padding(3, 4, 3, 4);
            textBoxDoctorSpecDetails.Name = "textBoxDoctorSpecDetails";
            textBoxDoctorSpecDetails.ReadOnly = true;
            textBoxDoctorSpecDetails.Size = new Size(431, 34);
            textBoxDoctorSpecDetails.TabIndex = 83;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(131, 36);
            label6.Name = "label6";
            label6.Size = new Size(356, 36);
            label6.TabIndex = 82;
            label6.Text = "Appointment details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(85, 423);
            label5.Name = "label5";
            label5.Size = new Size(53, 28);
            label5.TabIndex = 80;
            label5.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(84, 340);
            label3.Name = "label3";
            label3.Size = new Size(209, 28);
            label3.TabIndex = 79;
            label3.Text = "Doctor's specialization";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(84, 261);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 78;
            label4.Text = "Doctor's name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 178);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 77;
            label2.Text = "Patient's pesel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 107);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 76;
            label1.Text = "Patient's name";
            // 
            // textBoxDateDetails
            // 
            textBoxDateDetails.BackColor = Color.White;
            textBoxDateDetails.Enabled = false;
            textBoxDateDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDateDetails.Location = new Point(84, 455);
            textBoxDateDetails.Margin = new Padding(3, 4, 3, 4);
            textBoxDateDetails.Name = "textBoxDateDetails";
            textBoxDateDetails.ReadOnly = true;
            textBoxDateDetails.Size = new Size(429, 34);
            textBoxDateDetails.TabIndex = 90;
            // 
            // FormAppointmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 648);
            Controls.Add(textBoxDateDetails);
            Controls.Add(textBoxDoctorNameDetails);
            Controls.Add(comboBoxPatientNameDetails);
            Controls.Add(comboBoxPatientPeselDetails);
            Controls.Add(btnOkDetails);
            Controls.Add(textBoxDoctorSpecDetails);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAppointmentDetails";
            Text = "Appointment Details";
            Load += FormAppointmentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDoctorNameDetails;
        private ComboBox comboBoxPatientNameDetails;
        private ComboBox comboBoxPatientPeselDetails;
        private FontAwesome.Sharp.IconButton btnOkDetails;
        private TextBox textBoxDoctorSpecDetails;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBoxDateDetails;
    }
}