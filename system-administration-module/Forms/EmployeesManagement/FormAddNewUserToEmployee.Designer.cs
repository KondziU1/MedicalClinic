namespace SystemAdministrationModule.Forms
{
    partial class FormAddNewUserToEmployee
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
            label10 = new Label();
            btnSkip = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            textBoxLogin = new TextBox();
            label1 = new Label();
            textBoxPassword = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(65, 22);
            label10.Name = "label10";
            label10.Size = new Size(447, 29);
            label10.TabIndex = 21;
            label10.Text = "Add a new user to the employee";
            // 
            // btnSkip
            // 
            btnSkip.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSkip.BackColor = Color.FromArgb(73, 80, 87);
            btnSkip.Cursor = Cursors.Hand;
            btnSkip.FlatAppearance.BorderSize = 0;
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSkip.ForeColor = Color.White;
            btnSkip.IconChar = FontAwesome.Sharp.IconChar.Forward;
            btnSkip.IconColor = Color.White;
            btnSkip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSkip.IconSize = 35;
            btnSkip.Location = new Point(75, 225);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(200, 58);
            btnSkip.TabIndex = 22;
            btnSkip.Text = "Skip";
            btnSkip.TextAlign = ContentAlignment.MiddleRight;
            btnSkip.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(73, 80, 87);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(299, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 58);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(75, 94);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(424, 29);
            textBoxLogin.TabIndex = 25;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 70);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 24;
            label1.Text = "Login";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(75, 152);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(424, 29);
            textBoxPassword.TabIndex = 29;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(75, 128);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // FormAddNewUserToEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 319);
            ControlBox = false;
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnSkip);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormAddNewUserToEmployee";
            Text = "Add a new user to the employee";
            FormClosed += FormAddNewUserToEmployee_FormClosed;
            Load += FormAddNewUserToEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnSkip;
        private FontAwesome.Sharp.IconButton btnAdd;
        private TextBox textBoxLogin;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label3;
    }
}