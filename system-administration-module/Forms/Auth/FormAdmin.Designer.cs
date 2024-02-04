namespace SystemAdministrationModule
{
    partial class FormAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panelMenu = new Panel();
            logedUser = new FontAwesome.Sharp.IconButton();
            btnCalendar = new FontAwesome.Sharp.IconButton();
            btnSettings = new FontAwesome.Sharp.IconButton();
            btnOffices = new FontAwesome.Sharp.IconButton();
            btnUsers = new FontAwesome.Sharp.IconButton();
            btnSpecializations = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
            btnEmployees = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(73, 80, 87);
            panelMenu.Controls.Add(logedUser);
            panelMenu.Controls.Add(btnCalendar);
            panelMenu.Controls.Add(btnSettings);
            panelMenu.Controls.Add(btnOffices);
            panelMenu.Controls.Add(btnUsers);
            panelMenu.Controls.Add(btnSpecializations);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(btnEmployees);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(235, 838);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // logedUser
            // 
            logedUser.Dock = DockStyle.Bottom;
            logedUser.FlatAppearance.BorderSize = 0;
            logedUser.FlatStyle = FlatStyle.Flat;
            logedUser.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            logedUser.ForeColor = Color.White;
            logedUser.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            logedUser.IconColor = Color.White;
            logedUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logedUser.ImageAlign = ContentAlignment.MiddleLeft;
            logedUser.Location = new Point(0, 664);
            logedUser.Name = "logedUser";
            logedUser.Padding = new Padding(10, 0, 0, 0);
            logedUser.Size = new Size(235, 58);
            logedUser.TabIndex = 9;
            logedUser.Text = "LoggedUser";
            logedUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            logedUser.UseVisualStyleBackColor = true;
            // 
            // btnCalendar
            // 
            btnCalendar.Cursor = Cursors.Hand;
            btnCalendar.Dock = DockStyle.Top;
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnCalendar.FlatStyle = FlatStyle.Flat;
            btnCalendar.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalendar.ForeColor = Color.White;
            btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btnCalendar.IconColor = Color.White;
            btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendar.Location = new Point(0, 405);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(10, 0, 0, 0);
            btnCalendar.Size = new Size(235, 58);
            btnCalendar.TabIndex = 8;
            btnCalendar.Text = "Calendars";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnSettings
            // 
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            btnSettings.IconColor = Color.White;
            btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 722);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(10, 0, 0, 0);
            btnSettings.Size = new Size(235, 58);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnOffices
            // 
            btnOffices.Cursor = Cursors.Hand;
            btnOffices.Dock = DockStyle.Top;
            btnOffices.FlatAppearance.BorderSize = 0;
            btnOffices.FlatStyle = FlatStyle.Flat;
            btnOffices.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOffices.ForeColor = Color.White;
            btnOffices.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            btnOffices.IconColor = Color.White;
            btnOffices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnOffices.ImageAlign = ContentAlignment.MiddleLeft;
            btnOffices.Location = new Point(0, 347);
            btnOffices.Name = "btnOffices";
            btnOffices.Padding = new Padding(10, 0, 0, 0);
            btnOffices.Size = new Size(235, 58);
            btnOffices.TabIndex = 7;
            btnOffices.Text = "Offices";
            btnOffices.TextAlign = ContentAlignment.MiddleLeft;
            btnOffices.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOffices.UseVisualStyleBackColor = true;
            btnOffices.Click += btnOffices_Click;
            // 
            // btnUsers
            // 
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.Dock = DockStyle.Top;
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnUsers.ForeColor = Color.White;
            btnUsers.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnUsers.IconColor = Color.White;
            btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(0, 289);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(10, 0, 0, 0);
            btnUsers.Size = new Size(235, 58);
            btnUsers.TabIndex = 6;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnSpecializations
            // 
            btnSpecializations.Cursor = Cursors.Hand;
            btnSpecializations.Dock = DockStyle.Top;
            btnSpecializations.FlatAppearance.BorderSize = 0;
            btnSpecializations.FlatStyle = FlatStyle.Flat;
            btnSpecializations.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpecializations.ForeColor = Color.White;
            btnSpecializations.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnSpecializations.IconColor = Color.White;
            btnSpecializations.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSpecializations.ImageAlign = ContentAlignment.MiddleLeft;
            btnSpecializations.Location = new Point(0, 231);
            btnSpecializations.Name = "btnSpecializations";
            btnSpecializations.Padding = new Padding(10, 0, 0, 0);
            btnSpecializations.Size = new Size(235, 58);
            btnSpecializations.TabIndex = 5;
            btnSpecializations.Text = "Specializations";
            btnSpecializations.TextAlign = ContentAlignment.MiddleLeft;
            btnSpecializations.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSpecializations.UseVisualStyleBackColor = true;
            btnSpecializations.Click += btnSpecializations_Click;
            // 
            // btnLogout
            // 
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnLogout.IconColor = Color.White;
            btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 780);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(235, 58);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.Cursor = Cursors.Hand;
            btnEmployees.Dock = DockStyle.Top;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmployees.ForeColor = Color.White;
            btnEmployees.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnEmployees.IconColor = Color.White;
            btnEmployees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmployees.Location = new Point(0, 173);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Padding = new Padding(10, 0, 0, 0);
            btnEmployees.Size = new Size(235, 58);
            btnEmployees.TabIndex = 2;
            btnEmployees.Text = "Employees";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += BtnEmployees_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 173);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(248, 249, 250);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(235, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1497, 838);
            panelDesktop.TabIndex = 2;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1732, 838);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Name = "FormAdmin";
            Text = "Administration module";
            FormClosing += FormMain_FormClosing;
            Load += FormHome_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelDesktop;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnEmployees;
        private FontAwesome.Sharp.IconButton btnSpecializations;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnOffices;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconButton logedUser;
    }
}