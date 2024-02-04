namespace SystemAdministrationModule.Forms.UserManagement
{
    partial class FormUsers
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
            dataGridViewUsers = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            login = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            review = new DataGridViewButtonColumn();
            action = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            btnAddUser = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxLastName = new TextBox();
            label5 = new Label();
            textBoxFirstName = new TextBox();
            label4 = new Label();
            textBoxLogin = new TextBox();
            label3 = new Label();
            comboBoxRoles = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToResizeColumns = false;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.ColumnHeadersHeight = 55;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { id, login, firstName, lastName, role, email, status, review, action, Edit });
            dataGridViewUsers.EnableHeadersVisualStyles = false;
            dataGridViewUsers.Location = new Point(35, 86);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewUsers.RowHeadersVisible = false;
            dataGridViewUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewUsers.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewUsers.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewUsers.RowTemplate.Height = 55;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(1622, 752);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            dataGridViewUsers.Paint += dataGridViewUsers_Paint;
            // 
            // id
            // 
            id.FillWeight = 279.187866F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 50;
            // 
            // login
            // 
            login.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            login.FillWeight = 82.0812149F;
            login.HeaderText = "Login";
            login.Name = "login";
            login.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstName.HeaderText = "First Name";
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastName.HeaderText = "Last Name";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.HeaderText = "Role";
            role.Name = "role";
            role.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.FillWeight = 82.0812149F;
            email.HeaderText = "E-mail";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.FillWeight = 82.0812149F;
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
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
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddUser.BackColor = Color.FromArgb(73, 80, 87);
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddUser.IconColor = Color.White;
            btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddUser.Location = new Point(35, 881);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(309, 58);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Add new user";
            btnAddUser.TextAlign = ContentAlignment.MiddleRight;
            btnAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 4;
            label1.Text = "Users";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxLastName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxLogin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBoxRoles);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1043, 866);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(614, 73);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filters";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(314, 32);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(133, 23);
            textBoxLastName.TabIndex = 8;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 14);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 7;
            label5.Text = "Last name";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(166, 32);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(133, 23);
            textBoxFirstName.TabIndex = 6;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 14);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 5;
            label4.Text = "First name";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(18, 32);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(133, 23);
            textBoxLogin.TabIndex = 4;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 14);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(462, 32);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(133, 23);
            comboBoxRoles.TabIndex = 2;
            comboBoxRoles.SelectedIndexChanged += comboBoxRoles_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 16);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1701, 987);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnAddUser);
            Controls.Add(dataGridViewUsers);
            Name = "FormUsers";
            Text = "Users list";
            Load += FormUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private FontAwesome.Sharp.IconButton btnAddUser;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBoxRoles;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label5;
        private TextBox textBoxFirstName;
        private Label label4;
        private TextBox textBoxLogin;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn login;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn review;
        private DataGridViewButtonColumn action;
        private DataGridViewButtonColumn Edit;
    }
}