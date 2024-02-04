namespace SystemAdministrationModule.Forms
{
    partial class FormEmployees
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
            label1 = new Label();
            dataGridViewEmployees = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            pesel = new DataGridViewTextBoxColumn();
            dateOfBirth = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            sex = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            review = new DataGridViewButtonColumn();
            action = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            btnAddEmpoloyee = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            label3 = new Label();
            comboBoxRoles = new ComboBox();
            label2 = new Label();
            comboBoxStatuses = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 47);
            label1.Name = "label1";
            label1.Size = new Size(198, 36);
            label1.TabIndex = 0;
            label1.Text = "Employees";
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AllowUserToDeleteRows = false;
            dataGridViewEmployees.AllowUserToResizeColumns = false;
            dataGridViewEmployees.AllowUserToResizeRows = false;
            dataGridViewEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEmployees.BackgroundColor = Color.White;
            dataGridViewEmployees.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEmployees.ColumnHeadersHeight = 55;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { id, firstName, lastName, pesel, dateOfBirth, role, address, email, sex, status, review, action, Edit });
            dataGridViewEmployees.EnableHeadersVisualStyles = false;
            dataGridViewEmployees.Location = new Point(40, 115);
            dataGridViewEmployees.Margin = new Padding(3, 4, 3, 4);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewEmployees.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewEmployees.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewEmployees.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewEmployees.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewEmployees.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewEmployees.RowTemplate.Height = 55;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(1854, 742);
            dataGridViewEmployees.TabIndex = 1;
            dataGridViewEmployees.CellClick += DataGridViewEmployees_CellClick;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
            dataGridViewEmployees.Paint += dataGridViewEmployees_Paint;
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
            firstName.FillWeight = 82.0812149F;
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 6;
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastName.FillWeight = 82.0812149F;
            lastName.HeaderText = "Last Name";
            lastName.MinimumWidth = 6;
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // pesel
            // 
            pesel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pesel.FillWeight = 82.0812149F;
            pesel.HeaderText = "PESEL";
            pesel.MinimumWidth = 6;
            pesel.Name = "pesel";
            pesel.ReadOnly = true;
            // 
            // dateOfBirth
            // 
            dateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateOfBirth.FillWeight = 82.0812149F;
            dateOfBirth.HeaderText = "Date of birth";
            dateOfBirth.MinimumWidth = 6;
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.ReadOnly = true;
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.FillWeight = 82.0812149F;
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            role.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.FillWeight = 82.0812149F;
            address.HeaderText = "Address";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.FillWeight = 82.0812149F;
            email.HeaderText = "E-mail";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // sex
            // 
            sex.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            sex.FillWeight = 82.0812149F;
            sex.HeaderText = "Sex";
            sex.MinimumWidth = 6;
            sex.Name = "sex";
            sex.ReadOnly = true;
            sex.Width = 80;
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
            review.FillWeight = 82.0812149F;
            review.HeaderText = "Review";
            review.MinimumWidth = 6;
            review.Name = "review";
            review.ReadOnly = true;
            review.Resizable = DataGridViewTriState.True;
            review.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            action.DefaultCellStyle = dataGridViewCellStyle3;
            action.HeaderText = "Action";
            action.MinimumWidth = 6;
            action.Name = "action";
            action.ReadOnly = true;
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
            // btnAddEmpoloyee
            // 
            btnAddEmpoloyee.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddEmpoloyee.BackColor = Color.FromArgb(73, 80, 87);
            btnAddEmpoloyee.Cursor = Cursors.Hand;
            btnAddEmpoloyee.FlatAppearance.BorderSize = 0;
            btnAddEmpoloyee.FlatStyle = FlatStyle.Flat;
            btnAddEmpoloyee.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddEmpoloyee.ForeColor = Color.White;
            btnAddEmpoloyee.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddEmpoloyee.IconColor = Color.White;
            btnAddEmpoloyee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddEmpoloyee.Location = new Point(40, 914);
            btnAddEmpoloyee.Margin = new Padding(3, 4, 3, 4);
            btnAddEmpoloyee.Name = "btnAddEmpoloyee";
            btnAddEmpoloyee.Size = new Size(353, 77);
            btnAddEmpoloyee.TabIndex = 2;
            btnAddEmpoloyee.Text = "Add new employee";
            btnAddEmpoloyee.TextAlign = ContentAlignment.MiddleRight;
            btnAddEmpoloyee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddEmpoloyee.UseVisualStyleBackColor = false;
            btnAddEmpoloyee.Click += BtnAddEmpoloyee_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxRoles);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxStatuses);
            groupBox1.Location = new Point(1523, 894);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(370, 97);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            groupBox1.Enter += groupBox1_Enter;
            //
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 23);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(198, 47);
            comboBoxRoles.Margin = new Padding(3, 4, 3, 4);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(151, 28);
            comboBoxRoles.TabIndex = 2;
            comboBoxRoles.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 23);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // comboBoxStatuses
            // 
            comboBoxStatuses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatuses.FormattingEnabled = true;
            comboBoxStatuses.Location = new Point(23, 47);
            comboBoxStatuses.Margin = new Padding(3, 4, 3, 4);
            comboBoxStatuses.Name = "comboBoxStatuses";
            comboBoxStatuses.Size = new Size(151, 28);
            comboBoxStatuses.TabIndex = 0;
            comboBoxStatuses.SelectedIndexChanged += comboBoxStatuses_SelectedIndexChanged;
            // 
            // FormEmployees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1924, 1055);
            Controls.Add(groupBox1);
            Controls.Add(btnAddEmpoloyee);
            Controls.Add(dataGridViewEmployees);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEmployees";
            Text = "Employees list";
            Load += FormEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewEmployees;
        private FontAwesome.Sharp.IconButton btnAddEmpoloyee;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBoxRoles;
        private Label label2;
        private ComboBox comboBoxStatuses;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn pesel;
        private DataGridViewTextBoxColumn dateOfBirth;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn sex;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn review;
        private DataGridViewButtonColumn action;
        private DataGridViewButtonColumn Edit;
    }
}