namespace SystemAdministrationModule
{
    partial class FormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            panelMenu = new Panel();
            btnCalendar = new FontAwesome.Sharp.IconButton();
            btnPatients = new FontAwesome.Sharp.IconButton();
            btnLogout = new FontAwesome.Sharp.IconButton();
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
            panelMenu.Controls.Add(btnCalendar);
            panelMenu.Controls.Add(btnPatients);
            panelMenu.Controls.Add(btnLogout);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(235, 791);
            panelMenu.TabIndex = 0;
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
            btnCalendar.Location = new Point(0, 231);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Padding = new Padding(10, 0, 0, 0);
            btnCalendar.Size = new Size(235, 58);
            btnCalendar.TabIndex = 9;
            btnCalendar.Text = "Calendars";
            btnCalendar.TextAlign = ContentAlignment.MiddleLeft;
            btnCalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnPatients
            // 
            btnPatients.Cursor = Cursors.Hand;
            btnPatients.Dock = DockStyle.Top;
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatients.ForeColor = Color.White;
            btnPatients.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnPatients.IconColor = Color.White;
            btnPatients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(0, 173);
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new Padding(10, 0, 0, 0);
            btnPatients.Size = new Size(235, 58);
            btnPatients.TabIndex = 4;
            btnPatients.Text = "Patients";
            btnPatients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatients.UseVisualStyleBackColor = true;
            btnPatients.Click += btnPatients_Click;
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
            btnLogout.Location = new Point(0, 733);
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
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(248, 249, 250);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(235, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1449, 791);
            panelDesktop.TabIndex = 2;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1684, 791);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Name = "FormStaff";
            Text = "FormMain";
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
        private FontAwesome.Sharp.IconButton btnLogout;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnPatients;
        private FontAwesome.Sharp.IconButton btnCalendar;
    }
}