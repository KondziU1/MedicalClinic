namespace SystemAdministrationModule.Forms.CalendarManagement
{
    partial class FormCalendars
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnAddCalendar = new FontAwesome.Sharp.IconButton();
            dataGridViewCalendars = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxName = new TextBox();
            label3 = new Label();
            comboBoxStatus = new ComboBox();
            label2 = new Label();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            dateStart = new DataGridViewTextBoxColumn();
            dateEnd = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            active = new DataGridViewTextBoxColumn();
            details = new DataGridViewButtonColumn();
            remove = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddCalendar
            // 
            btnAddCalendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCalendar.BackColor = Color.FromArgb(73, 80, 87);
            btnAddCalendar.Cursor = Cursors.Hand;
            btnAddCalendar.FlatAppearance.BorderSize = 0;
            btnAddCalendar.FlatStyle = FlatStyle.Flat;
            btnAddCalendar.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddCalendar.ForeColor = Color.White;
            btnAddCalendar.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddCalendar.IconColor = Color.White;
            btnAddCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddCalendar.Location = new Point(49, 913);
            btnAddCalendar.Margin = new Padding(3, 4, 3, 4);
            btnAddCalendar.Name = "btnAddCalendar";
            btnAddCalendar.Size = new Size(353, 77);
            btnAddCalendar.TabIndex = 5;
            btnAddCalendar.Text = "Add new calendar";
            btnAddCalendar.TextAlign = ContentAlignment.MiddleRight;
            btnAddCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddCalendar.UseVisualStyleBackColor = false;
            btnAddCalendar.Click += btnAddCalendar_Click;
            // 
            // dataGridViewCalendars
            // 
            dataGridViewCalendars.AllowUserToAddRows = false;
            dataGridViewCalendars.AllowUserToDeleteRows = false;
            dataGridViewCalendars.AllowUserToResizeColumns = false;
            dataGridViewCalendars.AllowUserToResizeRows = false;
            dataGridViewCalendars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCalendars.BackgroundColor = Color.White;
            dataGridViewCalendars.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCalendars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewCalendars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCalendars.ColumnHeadersHeight = 55;
            dataGridViewCalendars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCalendars.Columns.AddRange(new DataGridViewColumn[] { id, name, dateStart, dateEnd, status, active, details, remove, Edit });
            dataGridViewCalendars.EnableHeadersVisualStyles = false;
            dataGridViewCalendars.Location = new Point(49, 132);
            dataGridViewCalendars.Margin = new Padding(3, 4, 3, 4);
            dataGridViewCalendars.Name = "dataGridViewCalendars";
            dataGridViewCalendars.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewCalendars.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCalendars.RowHeadersVisible = false;
            dataGridViewCalendars.RowHeadersWidth = 51;
            dataGridViewCalendars.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCalendars.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewCalendars.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCalendars.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewCalendars.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewCalendars.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewCalendars.RowTemplate.Height = 55;
            dataGridViewCalendars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCalendars.Size = new Size(1845, 723);
            dataGridViewCalendars.TabIndex = 4;
            dataGridViewCalendars.CellClick += dataGridViewEmployees_CellClick;
            dataGridViewCalendars.CellContentClick += dataGridViewCalendars_CellContentClick;
            dataGridViewCalendars.Paint += dataGridViewEmployees_Paint;
            // 
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 48);
            label1.Name = "label1";
            label1.Size = new Size(146, 29);
            label1.TabIndex = 3;
            label1.Text = "Calendars";
            //
            // groupBox1
            //
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1338, 865);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 73);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            //
            // textBoxName
            //
            textBoxName.Location = new Point(18, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(133, 23);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBoxName_TextChanged;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(167, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Status";
            //
            // comboBoxStatus
            //
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(167, 32);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(133, 23);
            comboBoxStatus.TabIndex = 2;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(18, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            //
            // id
            // 
            id.FillWeight = 279.187866F;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 50;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // dateStart
            // 
            dateStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateStart.FillWeight = 82.0812149F;
            dateStart.HeaderText = "Date start";
            dateStart.MinimumWidth = 6;
            dateStart.Name = "dateStart";
            dateStart.ReadOnly = true;
            // 
            // dateEnd
            // 
            dateEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateEnd.FillWeight = 82.0812149F;
            dateEnd.HeaderText = "Date end";
            dateEnd.MinimumWidth = 6;
            dateEnd.Name = "dateEnd";
            dateEnd.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // active
            //
            active.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            active.HeaderText = "Active";
            active.Name = "active";
            active.ReadOnly = true;
            //
            // details
            // 
            details.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            details.DataPropertyName = "ReviewBtn";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(10);
            details.DefaultCellStyle = dataGridViewCellStyle2;
            details.FillWeight = 82.0812149F;
            details.HeaderText = "Details";
            details.MinimumWidth = 6;
            details.Name = "details";
            details.ReadOnly = true;
            details.Resizable = DataGridViewTriState.True;
            details.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // remove
            // 
            remove.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            remove.DefaultCellStyle = dataGridViewCellStyle3;
            remove.HeaderText = "Remove";
            remove.MinimumWidth = 6;
            remove.Name = "remove";
            remove.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle4;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 64);
            label1.Name = "label1";
            label1.Size = new Size(182, 36);
            label1.TabIndex = 3;
            label1.Text = "Calendars";
            label1.Click += label1_Click;
            //
            // groupBox1
            //
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1529, 893);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(365, 97);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            //
            // textBoxName
            //
            textBoxName.Location = new Point(21, 43);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(151, 27);
            textBoxName.TabIndex = 4;
            textBoxName.TextChanged += textBoxName_TextChanged;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(191, 19);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 3;
            label3.Text = "Status";
            //
            // comboBoxStatus
            //
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(191, 43);
            comboBoxStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 2;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(21, 21);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            //
            // btnDoctorScheadule
            //

            // 
            // FormCalendars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1701, 987);
            ControlBox = false;
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Controls.Add(btnAddCalendar);
            Controls.Add(dataGridViewCalendars);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCalendars";
            Text = "Calendars";
            Load += FormCalendars_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCalendars).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddCalendar;
        private DataGridView dataGridViewCalendars;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label3;
        private ComboBox comboBoxStatus;
        private Label label2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn dateStart;
        private DataGridViewTextBoxColumn dateEnd;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn active;
        private DataGridViewButtonColumn details;
        private DataGridViewButtonColumn remove;
        private DataGridViewButtonColumn Edit;
    }
}