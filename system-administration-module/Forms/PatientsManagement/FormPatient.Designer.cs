using System.Windows.Forms;

namespace SystemAdministrationModule.Forms.PatientsManagement
{
    partial class FormPatient
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridViewPatient = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dateTimePickerLastVisit = new DateTimePicker();
            textBoxPesel = new TextBox();
            textBoxFiltersLastName = new TextBox();
            textBoxFiltersName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSearch = new FontAwesome.Sharp.IconButton();
            btnAddEPatient = new FontAwesome.Sharp.IconButton();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            pesel = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            review = new DataGridViewButtonColumn();
            Action = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            StatusChange = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPatient
            // 
            dataGridViewPatient.AllowUserToAddRows = false;
            dataGridViewPatient.AllowUserToDeleteRows = false;
            dataGridViewPatient.AllowUserToResizeColumns = false;
            dataGridViewPatient.AllowUserToResizeRows = false;
            dataGridViewPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewPatient.BackgroundColor = Color.White;
            dataGridViewPatient.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewPatient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPatient.ColumnHeadersHeight = 55;
            dataGridViewPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPatient.Columns.AddRange(new DataGridViewColumn[] { id, firstName, lastName, pesel, status, review, Action, Edit, StatusChange });
            dataGridViewPatient.EnableHeadersVisualStyles = false;
            dataGridViewPatient.Location = new Point(77, 103);
            dataGridViewPatient.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPatient.Name = "dataGridViewPatient";
            dataGridViewPatient.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewPatient.RowHeadersVisible = false;
            dataGridViewPatient.RowHeadersWidth = 51;
            dataGridViewPatient.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewPatient.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewPatient.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewPatient.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPatient.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewPatient.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewPatient.RowTemplate.Height = 55;
            dataGridViewPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPatient.Size = new Size(1356, 441);
            dataGridViewPatient.TabIndex = 2;
            dataGridViewPatient.CellContentClick += dataGridViewPatient_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 40);
            label1.Name = "label1";
            label1.Size = new Size(154, 36);
            label1.TabIndex = 3;
            label1.Text = "Patients";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(dateTimePickerLastVisit);
            groupBox1.Controls.Add(textBoxPesel);
            groupBox1.Controls.Add(textBoxFiltersLastName);
            groupBox1.Controls.Add(textBoxFiltersName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(77, 708);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(864, 97);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // dateTimePickerLastVisit
            // 
            dateTimePickerLastVisit.Location = new Point(504, 48);
            dateTimePickerLastVisit.Name = "dateTimePickerLastVisit";
            dateTimePickerLastVisit.Size = new Size(290, 27);
            dateTimePickerLastVisit.TabIndex = 11;
            dateTimePickerLastVisit.ValueChanged += dateTimePickerLastVisit_ValueChanged;
            // 
            // textBoxPesel
            // 
            textBoxPesel.Location = new Point(352, 48);
            textBoxPesel.Name = "textBoxPesel";
            textBoxPesel.Size = new Size(125, 27);
            textBoxPesel.TabIndex = 10;
            textBoxPesel.TextChanged += textBoxPesel_TextChanged;
            // 
            // textBoxFiltersLastName
            // 
            textBoxFiltersLastName.Location = new Point(198, 48);
            textBoxFiltersLastName.Name = "textBoxFiltersLastName";
            textBoxFiltersLastName.Size = new Size(125, 27);
            textBoxFiltersLastName.TabIndex = 9;
            textBoxFiltersLastName.TextChanged += textBoxFiltersLastName_TextChanged;
            // 
            // textBoxFiltersName
            // 
            textBoxFiltersName.Location = new Point(23, 48);
            textBoxFiltersName.Name = "textBoxFiltersName";
            textBoxFiltersName.Size = new Size(125, 27);
            textBoxFiltersName.TabIndex = 8;
            textBoxFiltersName.TextChanged += textBoxFiltersName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 24);
            label5.Name = "label5";
            label5.Size = new Size(154, 20);
            label5.TabIndex = 7;
            label5.Text = "Date of the latest visit";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 24);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Pesel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 24);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 24);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.BackColor = Color.FromArgb(73, 80, 87);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnSearch.IconColor = Color.White;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.Location = new Point(1163, 722);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(270, 83);
            btnSearch.TabIndex = 43;
            btnSearch.Text = "Clear filter";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddEPatient
            // 
            btnAddEPatient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddEPatient.BackColor = Color.FromArgb(73, 80, 87);
            btnAddEPatient.Cursor = Cursors.Hand;
            btnAddEPatient.FlatAppearance.BorderSize = 0;
            btnAddEPatient.FlatStyle = FlatStyle.Flat;
            btnAddEPatient.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEPatient.ForeColor = Color.White;
            btnAddEPatient.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddEPatient.IconColor = Color.White;
            btnAddEPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddEPatient.Location = new Point(1080, 12);
            btnAddEPatient.Name = "btnAddEPatient";
            btnAddEPatient.Size = new Size(353, 77);
            btnAddEPatient.TabIndex = 44;
            btnAddEPatient.Text = "Add new patient";
            btnAddEPatient.TextAlign = ContentAlignment.MiddleRight;
            btnAddEPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEPatient.UseVisualStyleBackColor = false;
            btnAddEPatient.Click += btnAddEPatient_Click;
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
            // firstName
            // 
            firstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstName.FillWeight = 80.29814F;
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 6;
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastName.FillWeight = 80.29814F;
            lastName.HeaderText = "Last Name";
            lastName.MinimumWidth = 6;
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // pesel
            // 
            pesel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pesel.FillWeight = 80.29814F;
            pesel.HeaderText = "PESEL";
            pesel.MinimumWidth = 6;
            pesel.Name = "pesel";
            pesel.ReadOnly = true;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
            // 
            // review
            // 
            review.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            review.DataPropertyName = "ReviewBtn";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(10);
            review.DefaultCellStyle = dataGridViewCellStyle2;
            review.FillWeight = 80.29814F;
            review.HeaderText = "Review";
            review.MinimumWidth = 6;
            review.Name = "review";
            review.ReadOnly = true;
            review.Resizable = DataGridViewTriState.True;
            review.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            Action.DefaultCellStyle = dataGridViewCellStyle3;
            Action.FillWeight = 97.82767F;
            Action.HeaderText = "Delete";
            Action.MinimumWidth = 6;
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle4;
            Edit.FillWeight = 97.82767F;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            // 
            // StatusChange
            // 
            StatusChange.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Padding = new Padding(10);
            StatusChange.DefaultCellStyle = dataGridViewCellStyle5;
            StatusChange.FillWeight = 97.82767F;
            StatusChange.HeaderText = "Status change";
            StatusChange.MinimumWidth = 6;
            StatusChange.Name = "StatusChange";
            StatusChange.ReadOnly = true;
            // 
            // FormPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 847);
            Controls.Add(btnAddEPatient);
            Controls.Add(btnSearch);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridViewPatient);
            Name = "FormPatient";
            Text = "List of patiens";
            Load += FormPatient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPatient).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewPatient;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePickerLastVisit;
        private TextBox textBoxPesel;

        private TextBox textBoxFiltersLastName;
        private TextBox textBoxFiltersName;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnAddEPatient;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn review;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn StatusChange;
    }
}