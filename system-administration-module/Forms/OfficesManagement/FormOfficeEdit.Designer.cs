namespace SystemAdministrationModule.Forms.OfficesManagement
{
    partial class FormOfficeEdit
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
            btnConfirm = new FontAwesome.Sharp.IconButton();
            btnCancel = new FontAwesome.Sharp.IconButton();
            labelTitle = new Label();
            textBoxNumber = new TextBox();
            label1 = new Label();
            comboBoxActiveStatus = new ComboBox();
            label13 = new Label();
            comboBoxSpecialization = new ComboBox();
            label14 = new Label();
            checkBoxIsGeneral = new CheckBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirm.BackColor = Color.FromArgb(73, 80, 87);
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirm.IconColor = Color.White;
            btnConfirm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirm.Location = new Point(446, 339);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(283, 58);
            btnConfirm.TabIndex = 64;
            btnConfirm.Text = "Confirm";
            btnConfirm.TextAlign = ContentAlignment.MiddleRight;
            btnConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
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
            btnCancel.Location = new Point(67, 339);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(283, 58);
            btnCancel.TabIndex = 63;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(320, 41);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(147, 29);
            labelTitle.TabIndex = 62;
            labelTitle.Text = "Edit office";
            // 
            // textBoxNumber
            // 
            textBoxNumber.BackColor = Color.White;
            textBoxNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumber.Location = new Point(67, 143);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(283, 29);
            textBoxNumber.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 119);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 65;
            label1.Text = "Number";
            // 
            // comboBoxActiveStatus
            // 
            comboBoxActiveStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxActiveStatus.BackColor = Color.White;
            comboBoxActiveStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActiveStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActiveStatus.FormattingEnabled = true;
            comboBoxActiveStatus.Location = new Point(446, 143);
            comboBoxActiveStatus.Name = "comboBoxActiveStatus";
            comboBoxActiveStatus.Size = new Size(283, 29);
            comboBoxActiveStatus.TabIndex = 99;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(446, 119);
            label13.Name = "label13";
            label13.Size = new Size(97, 21);
            label13.TabIndex = 98;
            label13.Text = "Active status";
            // 
            // comboBoxSpecialization
            // 
            comboBoxSpecialization.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxSpecialization.BackColor = Color.White;
            comboBoxSpecialization.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialization.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSpecialization.FormattingEnabled = true;
            comboBoxSpecialization.Location = new Point(67, 236);
            comboBoxSpecialization.Name = "comboBoxSpecialization";
            comboBoxSpecialization.Size = new Size(283, 29);
            comboBoxSpecialization.TabIndex = 101;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(67, 212);
            label14.Name = "label14";
            label14.Size = new Size(105, 21);
            label14.TabIndex = 100;
            label14.Text = "Specialization";
            // 
            // checkBoxIsGeneral
            // 
            checkBoxIsGeneral.AutoSize = true;
            checkBoxIsGeneral.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIsGeneral.Location = new Point(460, 236);
            checkBoxIsGeneral.Name = "checkBoxIsGeneral";
            checkBoxIsGeneral.Size = new Size(83, 25);
            checkBoxIsGeneral.TabIndex = 102;
            checkBoxIsGeneral.Text = "General";
            checkBoxIsGeneral.UseVisualStyleBackColor = true;
            // 
            // FormOfficeEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            ControlBox = false;
            Controls.Add(checkBoxIsGeneral);
            Controls.Add(comboBoxSpecialization);
            Controls.Add(label14);
            Controls.Add(comboBoxActiveStatus);
            Controls.Add(label13);
            Controls.Add(textBoxNumber);
            Controls.Add(label1);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormOfficeEdit";
            Text = "Edit office";
            Load += FormOfficeEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnConfirm;
        private FontAwesome.Sharp.IconButton btnCancel;
        private Label labelTitle;
        private TextBox textBoxNumber;
        private Label label1;
        private ComboBox comboBoxActiveStatus;
        private Label label13;
        private ComboBox comboBoxSpecialization;
        private Label label14;
        private CheckBox checkBoxIsGeneral;
    }
}