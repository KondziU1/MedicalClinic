namespace SystemAdministrationModule.Forms.AppointmentsManagement
{
    partial class FormDisplayAppointments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridViewAppointment = new DataGridView();
            groupBox1 = new GroupBox();
            comboBoxDoctor = new ComboBox();
            label8 = new Label();
            dateTimePickerVisit = new DateTimePicker();
            textBoxPesel = new TextBox();
            textBoxFiltersDoctor = new TextBox();
            textBoxFiltersPatient = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClear = new FontAwesome.Sharp.IconButton();
            btnAddNewAppointment = new FontAwesome.Sharp.IconButton();
            btnCleanCalendar = new FontAwesome.Sharp.IconButton();
            ID = new DataGridViewTextBoxColumn();
            NamePatient = new DataGridViewTextBoxColumn();
            pesel = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            doctor = new DataGridViewTextBoxColumn();
            specjalization = new DataGridViewTextBoxColumn();
            Details = new DataGridViewButtonColumn();
            Reschedule = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            IssueAconfirmation = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(251, 36);
            label1.TabIndex = 5;
            label1.Text = "Appointments";
            // 
            // dataGridViewAppointment
            // 
            dataGridViewAppointment.AllowUserToAddRows = false;
            dataGridViewAppointment.AllowUserToDeleteRows = false;
            dataGridViewAppointment.AllowUserToResizeColumns = false;
            dataGridViewAppointment.AllowUserToResizeRows = false;
            dataGridViewAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAppointment.BackgroundColor = Color.White;
            dataGridViewAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAppointment.ColumnHeadersHeight = 80;
            dataGridViewAppointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewAppointment.Columns.AddRange(new DataGridViewColumn[] { ID, NamePatient, pesel, Date, doctor, specjalization, Details, Reschedule, Delete, IssueAconfirmation });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridViewAppointment.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewAppointment.EnableHeadersVisualStyles = false;
            dataGridViewAppointment.Location = new Point(23, 107);
            dataGridViewAppointment.Margin = new Padding(3, 4, 3, 4);
            dataGridViewAppointment.Name = "dataGridViewAppointment";
            dataGridViewAppointment.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewAppointment.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewAppointment.RowHeadersVisible = false;
            dataGridViewAppointment.RowHeadersWidth = 55;
            dataGridViewAppointment.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAppointment.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewAppointment.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewAppointment.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewAppointment.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewAppointment.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewAppointment.RowTemplate.Height = 55;
            dataGridViewAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppointment.Size = new Size(1781, 511);
            dataGridViewAppointment.TabIndex = 4;
            dataGridViewAppointment.CellContentClick += dataGridViewAppointment_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(comboBoxDoctor);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePickerVisit);
            groupBox1.Controls.Add(textBoxPesel);
            groupBox1.Controls.Add(textBoxFiltersDoctor);
            groupBox1.Controls.Add(textBoxFiltersPatient);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(442, 643);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1080, 97);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.BackColor = Color.White;
            comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(834, 43);
            comboBoxDoctor.Margin = new Padding(3, 4, 3, 4);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(191, 36);
            comboBoxDoctor.TabIndex = 28;
            comboBoxDoctor.SelectedIndexChanged += comboBoxDoctor_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(834, 19);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 7;
            label8.Text = "Specialization";
            label8.Click += label8_Click;
            // 
            // dateTimePickerVisit
            // 
            dateTimePickerVisit.Location = new Point(504, 48);
            dateTimePickerVisit.Name = "dateTimePickerVisit";
            dateTimePickerVisit.Size = new Size(290, 27);
            dateTimePickerVisit.TabIndex = 11;
            dateTimePickerVisit.ValueChanged += dateTimePickerVisit_ValueChanged;
            // 
            // textBoxPesel
            // 
            textBoxPesel.Location = new Point(352, 48);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(125, 27);
            textBoxPesel.TabIndex = 10;
            textBoxPesel.TextChanged += textBoxPesel_TextChanged;
            // 
            // textBoxFiltersDoctor
            // 
            textBoxFiltersDoctor.Location = new Point(198, 48);
            textBoxFiltersDoctor.Name = "textBoxFiltersDoctor";
            textBoxFiltersDoctor.Size = new Size(125, 27);
            textBoxFiltersDoctor.TabIndex = 9;
            textBoxFiltersDoctor.TextChanged += textBoxFiltersDoctor_TextChanged;
            // 
            // textBoxFiltersPatient
            // 
            textBoxFiltersPatient.Location = new Point(23, 48);
            textBoxFiltersPatient.Name = "textBoxFiltersPatient";
            textBoxFiltersPatient.Size = new Size(125, 27);
            textBoxFiltersPatient.TabIndex = 8;
            textBoxFiltersPatient.TextChanged += textBoxFiltersPatient_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 25);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 7;
            label5.Text = "Date of  visit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 25);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Pesel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 25);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Doctor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Patient";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(73, 80, 87);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnClear.IconColor = Color.White;
            btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClear.Location = new Point(1583, 657);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(221, 83);
            btnClear.TabIndex = 44;
            btnClear.Text = "Clear filter";
            btnClear.TextAlign = ContentAlignment.MiddleRight;
            btnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddNewAppointment
            // 
            btnAddNewAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewAppointment.BackColor = Color.FromArgb(73, 80, 87);
            btnAddNewAppointment.Cursor = Cursors.Hand;
            btnAddNewAppointment.FlatAppearance.BorderSize = 0;
            btnAddNewAppointment.FlatStyle = FlatStyle.Flat;
            btnAddNewAppointment.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddNewAppointment.ForeColor = Color.White;
            btnAddNewAppointment.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddNewAppointment.IconColor = Color.White;
            btnAddNewAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNewAppointment.Location = new Point(1450, 23);
            btnAddNewAppointment.Name = "btnAddNewAppointment";
            btnAddNewAppointment.Size = new Size(353, 77);
            btnAddNewAppointment.TabIndex = 45;
            btnAddNewAppointment.Text = "Add new appointment";
            btnAddNewAppointment.TextAlign = ContentAlignment.MiddleRight;
            btnAddNewAppointment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNewAppointment.UseVisualStyleBackColor = false;
            btnAddNewAppointment.Click += btnAddNewAppointment_Click;
            // 
            // btnCleanCalendar
            // 
            btnCleanCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCleanCalendar.BackColor = Color.FromArgb(73, 80, 87);
            btnCleanCalendar.Cursor = Cursors.Hand;
            btnCleanCalendar.FlatAppearance.BorderSize = 0;
            btnCleanCalendar.FlatStyle = FlatStyle.Flat;
            btnCleanCalendar.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCleanCalendar.ForeColor = Color.White;
            btnCleanCalendar.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            btnCleanCalendar.IconColor = Color.White;
            btnCleanCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCleanCalendar.Location = new Point(1090, 23);
            btnCleanCalendar.Name = "btnCleanCalendar";
            btnCleanCalendar.Size = new Size(353, 77);
            btnCleanCalendar.TabIndex = 46;
            btnCleanCalendar.Text = "Clean the calendar";
            btnCleanCalendar.TextAlign = ContentAlignment.MiddleRight;
            btnCleanCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCleanCalendar.UseVisualStyleBackColor = false;
            btnCleanCalendar.Click += btnCleanCalendar_Click;
            // 
            // ID
            // 
            ID.FillWeight = 279.187866F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 50;
            // 
            // NamePatient
            // 
            NamePatient.HeaderText = "Patient";
            NamePatient.MinimumWidth = 6;
            NamePatient.Name = "NamePatient";
            NamePatient.ReadOnly = true;
            NamePatient.Width = 180;
            // 
            // pesel
            // 
            pesel.HeaderText = "Patient's PESEL number";
            pesel.MinimumWidth = 6;
            pesel.Name = "pesel";
            pesel.ReadOnly = true;
            pesel.Width = 180;
            // 
            // Date
            // 
            Date.HeaderText = "Date of the visit";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 200;
            // 
            // doctor
            // 
            doctor.HeaderText = "Doctor";
            doctor.MinimumWidth = 6;
            doctor.Name = "doctor";
            doctor.ReadOnly = true;
            doctor.Width = 200;
            // 
            // specjalization
            // 
            specjalization.HeaderText = "Doctor's specialization";
            specjalization.MinimumWidth = 6;
            specjalization.Name = "specjalization";
            specjalization.ReadOnly = true;
            specjalization.Width = 200;
            // 
            // Details
            // 
            Details.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(10);
            Details.DefaultCellStyle = dataGridViewCellStyle2;
            Details.HeaderText = "Details";
            Details.MinimumWidth = 6;
            Details.Name = "Details";
            Details.ReadOnly = true;
            Details.Resizable = DataGridViewTriState.True;
            Details.Text = "Details";
            // 
            // Reschedule
            // 
            Reschedule.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            Reschedule.DefaultCellStyle = dataGridViewCellStyle3;
            Reschedule.HeaderText = "Reschedule";
            Reschedule.MinimumWidth = 6;
            Reschedule.Name = "Reschedule";
            Reschedule.ReadOnly = true;
            Reschedule.Resizable = DataGridViewTriState.True;
            Reschedule.Text = "Reschedule";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Transparent;
            dataGridViewCellStyle4.Padding = new Padding(10);
            Delete.DefaultCellStyle = dataGridViewCellStyle4;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.ToolTipText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // IssueAconfirmation
            // 
            IssueAconfirmation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(10);
            IssueAconfirmation.DefaultCellStyle = dataGridViewCellStyle5;
            IssueAconfirmation.HeaderText = "Issue a confirmation";
            IssueAconfirmation.MinimumWidth = 6;
            IssueAconfirmation.Name = "IssueAconfirmation";
            IssueAconfirmation.ReadOnly = true;
            IssueAconfirmation.Text = "Confirmation";
            IssueAconfirmation.ToolTipText = "Issue a confirmation";
            IssueAconfirmation.UseColumnTextForButtonValue = true;
            // 
            // FormDisplayAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1817, 764);
            Controls.Add(btnCleanCalendar);
            Controls.Add(btnAddNewAppointment);
            Controls.Add(btnClear);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridViewAppointment);
            Name = "FormDisplayAppointments";
            Text = "Display Appointments";
            Load += FormDisplayAppointments_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointment).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewAppointment;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerVisit;
        private TextBox textBoxPesel;
        private TextBox textBoxFiltersDoctor;
        private TextBox textBoxFiltersPatient;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxDoctor;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnAddNewAppointment;
        private FontAwesome.Sharp.IconButton btnCleanCalendar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamePatient;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn doctor;
        private DataGridViewTextBoxColumn specjalization;
        private DataGridViewButtonColumn Details;
        private DataGridViewButtonColumn Reschedule;
        private DataGridViewButtonColumn Delete;
        private DataGridViewButtonColumn IssueAconfirmation;
    }
}