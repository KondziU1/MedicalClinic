namespace SystemAdministrationModule.Forms.CalendarManagement
{
    partial class FormCalendarCreator
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanelContainer = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBoxDoctor = new ComboBox();
            label8 = new Label();
            comboBoxOffice = new ComboBox();
            label9 = new Label();
            dataGridViewVisits = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dateStart = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            selected = new DataGridViewCheckBoxColumn();
            btnSave = new FontAwesome.Sharp.IconButton();
            labelMonth = new Label();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            buttonSelect = new Button();
            buttonUnSelect = new Button();
            btnActive = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisits).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelContainer
            // 
            flowLayoutPanelContainer.Anchor = AnchorStyles.Left;
            flowLayoutPanelContainer.Location = new Point(25, 148);
            flowLayoutPanelContainer.Name = "flowLayoutPanelContainer";
            flowLayoutPanelContainer.Size = new Size(1097, 825);
            flowLayoutPanelContainer.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 115);
            label1.Name = "label1";
            label1.Size = new Size(89, 30);
            label1.TabIndex = 1;
            label1.Text = "Monday";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(217, 115);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 2;
            label2.Text = "Tuesday";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(361, 115);
            label3.Name = "label3";
            label3.Size = new Size(120, 30);
            label3.TabIndex = 3;
            label3.Text = "Wednesday";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(524, 115);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 4;
            label4.Text = "Thursday";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(697, 115);
            label5.Name = "label5";
            label5.Size = new Size(68, 30);
            label5.TabIndex = 5;
            label5.Text = "Friday";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(838, 115);
            label6.Name = "label6";
            label6.Size = new Size(94, 30);
            label6.TabIndex = 6;
            label6.Text = "Saturday";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1003, 115);
            label7.Name = "label7";
            label7.Size = new Size(81, 30);
            label7.TabIndex = 7;
            label7.Text = "Sunday";
            // 
            // comboBoxDoctor
            // 
            comboBoxDoctor.BackColor = Color.White;
            comboBoxDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDoctor.FormattingEnabled = true;
            comboBoxDoctor.Location = new Point(1168, 78);
            comboBoxDoctor.Name = "comboBoxDoctor";
            comboBoxDoctor.Size = new Size(200, 29);
            comboBoxDoctor.TabIndex = 26;
            comboBoxDoctor.SelectedIndexChanged += comboBoxDoctor_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1168, 54);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 25;
            label8.Text = "Doctor";
            // 
            // comboBoxOffice
            // 
            comboBoxOffice.BackColor = Color.White;
            comboBoxOffice.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOffice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOffice.FormattingEnabled = true;
            comboBoxOffice.Location = new Point(1401, 78);
            comboBoxOffice.Name = "comboBoxOffice";
            comboBoxOffice.Size = new Size(200, 29);
            comboBoxOffice.TabIndex = 28;
            comboBoxOffice.SelectedIndexChanged += comboBoxOffice_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1401, 54);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 27;
            label9.Text = "Office";
            // 
            // dataGridViewVisits
            // 
            dataGridViewVisits.AllowUserToAddRows = false;
            dataGridViewVisits.AllowUserToDeleteRows = false;
            dataGridViewVisits.AllowUserToResizeColumns = false;
            dataGridViewVisits.AllowUserToResizeRows = false;
            dataGridViewVisits.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewVisits.BackgroundColor = Color.White;
            dataGridViewVisits.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewVisits.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewVisits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVisits.ColumnHeadersHeight = 55;
            dataGridViewVisits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewVisits.Columns.AddRange(new DataGridViewColumn[] { id, dateStart, status, selected });
            dataGridViewVisits.EnableHeadersVisualStyles = false;
            dataGridViewVisits.Location = new Point(1170, 124);
            dataGridViewVisits.Name = "dataGridViewVisits";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewVisits.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVisits.RowHeadersVisible = false;
            dataGridViewVisits.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewVisits.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewVisits.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewVisits.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewVisits.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewVisits.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewVisits.RowTemplate.Height = 55;
            dataGridViewVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVisits.Size = new Size(809, 715);
            dataGridViewVisits.TabIndex = 29;
            // 
            // id
            // 
            id.FillWeight = 279.187866F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.Visible = false;
            id.Width = 50;
            // 
            // dateStart
            // 
            dateStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateStart.FillWeight = 82.0812149F;
            dateStart.HeaderText = "Date start";
            dateStart.Name = "dateStart";
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // selected
            // 
            selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(73, 80, 87);
            selected.DefaultCellStyle = dataGridViewCellStyle2;
            selected.HeaderText = "Selected";
            selected.Name = "selected";
            selected.Width = 90;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(73, 80, 87);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(1663, 915);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(316, 58);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save selected visits";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // labelMonth
            // 
            labelMonth.Anchor = AnchorStyles.Left;
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMonth.Location = new Point(25, 21);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(124, 47);
            labelMonth.TabIndex = 31;
            labelMonth.Text = "Month";
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
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btnEdit.IconColor = Color.White;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.Location = new Point(1663, 915);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(316, 58);
            btnEdit.TabIndex = 32;
            btnEdit.Text = "Turn on edit mode";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnCancel.Location = new Point(1461, 915);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(174, 58);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSelect.Location = new Point(1797, 77);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(182, 30);
            buttonSelect.TabIndex = 34;
            buttonSelect.Text = "Select all";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Visible = false;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonUnSelect
            // 
            buttonUnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUnSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUnSelect.Location = new Point(1797, 49);
            buttonUnSelect.Name = "buttonUnSelect";
            buttonUnSelect.Size = new Size(182, 30);
            buttonUnSelect.TabIndex = 35;
            buttonUnSelect.Text = "Unselect all";
            buttonUnSelect.UseVisualStyleBackColor = true;
            buttonUnSelect.Visible = false;
            buttonUnSelect.Click += buttonUnSelect_Click;
            // 
            // btnActive
            // 
            btnActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActive.BackColor = Color.FromArgb(73, 80, 87);
            btnActive.Cursor = Cursors.Hand;
            btnActive.FlatAppearance.BorderSize = 0;
            btnActive.FlatStyle = FlatStyle.Flat;
            btnActive.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnActive.ForeColor = Color.White;
            btnActive.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnActive.IconColor = Color.White;
            btnActive.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActive.IconSize = 45;
            btnActive.Location = new Point(1170, 915);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(266, 58);
            btnActive.TabIndex = 36;
            btnActive.Text = "Active calendar";
            btnActive.TextAlign = ContentAlignment.MiddleRight;
            btnActive.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnActive.UseVisualStyleBackColor = false;
            btnActive.Visible = false;
            btnActive.Click += btnActive_Click;
            // 
            // FormCalendarCreator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2013, 1036);
            ControlBox = false;
            Controls.Add(btnActive);
            Controls.Add(buttonUnSelect);
            Controls.Add(buttonSelect);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(labelMonth);
            Controls.Add(btnSave);
            Controls.Add(dataGridViewVisits);
            Controls.Add(comboBoxOffice);
            Controls.Add(label9);
            Controls.Add(comboBoxDoctor);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelContainer);
            Name = "FormCalendarCreator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendar";
            FormClosing += FormCalendarCreator_FormClosing;
            Load += FormCalendar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVisits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelContainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxDoctor;
        private Label label8;
        private ComboBox comboBoxOffice;
        private Label label9;
        private DataGridView dataGridViewVisits;
        private FontAwesome.Sharp.IconButton btnSave;
        private Label labelMonth;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dateStart;
        private DataGridViewTextBoxColumn status;
        private DataGridViewCheckBoxColumn selected;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Button buttonSelect;
        private Button buttonUnSelect;
        private FontAwesome.Sharp.IconButton btnActive;
    }
}