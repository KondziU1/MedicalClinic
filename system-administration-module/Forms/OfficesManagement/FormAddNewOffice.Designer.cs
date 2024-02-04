namespace SystemAdministrationModule.Forms.OfficesManagement
{
    partial class FormAddNewOffice
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
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            comboBoxSpecialization = new ComboBox();
            label5 = new Label();
            label1 = new Label();
            comboBoxType = new ComboBox();
            label2 = new Label();
            textBoxNumber = new TextBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(202, 64);
            label10.Name = "label10";
            label10.Size = new Size(237, 29);
            label10.TabIndex = 23;
            label10.Text = "Add a new office";
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
            btnCancel.Location = new Point(102, 387);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(200, 58);
            btnCancel.TabIndex = 22;
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
            btnAdd.Location = new Point(336, 387);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 58);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBoxSpecialization
            // 
            comboBoxSpecialization.BackColor = Color.White;
            comboBoxSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialization.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSpecialization.FormattingEnabled = true;
            comboBoxSpecialization.Location = new Point(102, 225);
            comboBoxSpecialization.Name = "comboBoxSpecialization";
            comboBoxSpecialization.Size = new Size(434, 29);
            comboBoxSpecialization.TabIndex = 25;
            comboBoxSpecialization.SelectedIndexChanged += comboBoxSpecialization_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(102, 201);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 24;
            label5.Text = "Specialization";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 133);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 26;
            label1.Text = "Number";
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(102, 290);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(434, 29);
            comboBoxType.TabIndex = 30;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(102, 266);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 29;
            label2.Text = "Type";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(102, 157);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(434, 29);
            textBoxNumber.TabIndex = 31;
            textBoxNumber.TextChanged += textBoxNumber_TextChanged;
            // 
            // FormAddNewOffice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 516);
            ControlBox = false;
            Controls.Add(textBoxNumber);
            Controls.Add(comboBoxType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxSpecialization);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAddNewOffice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add new office";
            Load += FormAddNewOffice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnAdd;
        private ComboBox comboBoxSpecialization;
        private Label label5;
        private Label label1;
        private ComboBox comboBoxType;
        private Label label2;
        private TextBox textBoxNumber;
    }
}