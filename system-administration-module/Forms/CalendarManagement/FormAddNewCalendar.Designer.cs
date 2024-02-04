namespace SystemAdministrationModule.Forms.CalendarManagement
{
    partial class FormAddNewCalendar
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
            components = new System.ComponentModel.Container();
            label10 = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            comboBoxDate = new ComboBox();
            label5 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            checkBoxBasedOnPrevious = new CheckBox();
            comboBoxCalendar = new ComboBox();
            label2 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(159, 44);
            label10.Name = "label10";
            label10.Size = new Size(279, 29);
            label10.TabIndex = 29;
            label10.Text = "Add a new calendar";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnCancel.Location = new Point(60, 295);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 58);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(336, 295);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 58);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxDate
            // 
            comboBoxDate.BackColor = Color.White;
            comboBoxDate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDate.FormattingEnabled = true;
            comboBoxDate.Location = new Point(336, 141);
            comboBoxDate.Name = "comboBoxDate";
            comboBoxDate.Size = new Size(200, 29);
            comboBoxDate.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(336, 117);
            label5.Name = "label5";
            label5.Size = new Size(42, 21);
            label5.TabIndex = 23;
            label5.Text = "Date";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.White;
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(60, 141);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 29);
            textBoxName.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 117);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 21;
            label1.Text = "Name";
            // 
            // checkBoxBasedOnPrevious
            // 
            checkBoxBasedOnPrevious.AutoSize = true;
            checkBoxBasedOnPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxBasedOnPrevious.Location = new Point(60, 215);
            checkBoxBasedOnPrevious.Name = "checkBoxBasedOnPrevious";
            checkBoxBasedOnPrevious.Size = new Size(156, 25);
            checkBoxBasedOnPrevious.TabIndex = 30;
            checkBoxBasedOnPrevious.Text = "Based on previous";
            checkBoxBasedOnPrevious.UseVisualStyleBackColor = true;
            checkBoxBasedOnPrevious.CheckedChanged += checkBoxBasedOnPrevious_CheckedChanged;
            // 
            // comboBoxCalendar
            // 
            comboBoxCalendar.BackColor = Color.White;
            comboBoxCalendar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCalendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCalendar.FormattingEnabled = true;
            comboBoxCalendar.Location = new Point(336, 213);
            comboBoxCalendar.Name = "comboBoxCalendar";
            comboBoxCalendar.Size = new Size(200, 29);
            comboBoxCalendar.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 189);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 31;
            label2.Text = "Base calendar";
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // FormAddNewCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 404);
            ControlBox = false;
            Controls.Add(comboBoxCalendar);
            Controls.Add(label2);
            Controls.Add(checkBoxBasedOnPrevious);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(comboBoxDate);
            Controls.Add(label5);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAddNewCalendar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new calendar";
            FormClosing += FormAddNewCalendar_FormClosing;
            Load += FormAddNewCalendar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAdd;
        private ComboBox comboBoxDate;
        private Label label5;
        private TextBox textBoxName;
        private Label label1;
        private CheckBox checkBoxBasedOnPrevious;
        private ComboBox comboBoxCalendar;
        private Label label2;
        private NotifyIcon notifyIcon1;
    }
}