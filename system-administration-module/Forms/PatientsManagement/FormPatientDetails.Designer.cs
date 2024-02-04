namespace SystemAdministrationModule.Forms.PatientsManagement
{
    partial class FormPatientDetails
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
            comboBoxActiveStatusPatient = new ComboBox();
            label13 = new Label();
            label10 = new Label();
            textBoxPeselPatient = new TextBox();
            label3 = new Label();
            textBoxLastNamePatient = new TextBox();
            label2 = new Label();
            textBoxFirstNamePatient = new TextBox();
            label1 = new Label();
            btnCancelPatient = new FontAwesome.Sharp.IconButton();
            btnConfirmPatient = new FontAwesome.Sharp.IconButton();
            btnEditPatient = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // comboBoxActiveStatusPatient
            // 
            comboBoxActiveStatusPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxActiveStatusPatient.BackColor = Color.White;
            comboBoxActiveStatusPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActiveStatusPatient.Enabled = false;
            comboBoxActiveStatusPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxActiveStatusPatient.FormattingEnabled = true;
            comboBoxActiveStatusPatient.Location = new Point(68, 452);
            comboBoxActiveStatusPatient.Margin = new Padding(3, 4, 3, 4);
            comboBoxActiveStatusPatient.Name = "comboBoxActiveStatusPatient";
            comboBoxActiveStatusPatient.Size = new Size(465, 36);
            comboBoxActiveStatusPatient.TabIndex = 108;
            comboBoxActiveStatusPatient.SelectedIndexChanged += comboBoxActiveStatusPatient_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(68, 420);
            label13.Name = "label13";
            label13.Size = new Size(122, 28);
            label13.TabIndex = 107;
            label13.Text = "Active status";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(195, 58);
            label10.Name = "label10";
            label10.Size = new Size(259, 36);
            label10.TabIndex = 106;
            label10.Text = "Patient details";
            // 
            // textBoxPeselPatient
            // 
            textBoxPeselPatient.BackColor = Color.White;
            textBoxPeselPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPeselPatient.Location = new Point(68, 358);
            textBoxPeselPatient.Margin = new Padding(3, 4, 3, 4);
            textBoxPeselPatient.Name = "textBoxPeselPatient";
            textBoxPeselPatient.Size = new Size(465, 34);
            textBoxPeselPatient.TabIndex = 105;
            textBoxPeselPatient.TextChanged += textBoxPeselPatient_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 326);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 104;
            label3.Text = "PESEL";
            // 
            // textBoxLastNamePatient
            // 
            textBoxLastNamePatient.BackColor = Color.White;
            textBoxLastNamePatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastNamePatient.Location = new Point(68, 263);
            textBoxLastNamePatient.Margin = new Padding(3, 4, 3, 4);
            textBoxLastNamePatient.Name = "textBoxLastNamePatient";
            textBoxLastNamePatient.Size = new Size(465, 34);
            textBoxLastNamePatient.TabIndex = 103;
            textBoxLastNamePatient.TextChanged += textBoxLastNamePatient_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 228);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 102;
            label2.Text = "Last Name";
            // 
            // textBoxFirstNamePatient
            // 
            textBoxFirstNamePatient.BackColor = Color.White;
            textBoxFirstNamePatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstNamePatient.Location = new Point(68, 171);
            textBoxFirstNamePatient.Margin = new Padding(3, 4, 3, 4);
            textBoxFirstNamePatient.Name = "textBoxFirstNamePatient";
            textBoxFirstNamePatient.Size = new Size(465, 34);
            textBoxFirstNamePatient.TabIndex = 101;
            textBoxFirstNamePatient.TextChanged += textBoxFirstNamePatient_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 139);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 100;
            label1.Text = "First Name";
            // 
            // btnCancelPatient
            // 
            btnCancelPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelPatient.BackColor = Color.FromArgb(73, 80, 87);
            btnCancelPatient.Cursor = Cursors.Hand;
            btnCancelPatient.FlatAppearance.BorderSize = 0;
            btnCancelPatient.FlatStyle = FlatStyle.Flat;
            btnCancelPatient.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelPatient.ForeColor = Color.White;
            btnCancelPatient.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCancelPatient.IconColor = Color.White;
            btnCancelPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelPatient.IconSize = 35;
            btnCancelPatient.Location = new Point(68, 511);
            btnCancelPatient.Margin = new Padding(3, 4, 3, 4);
            btnCancelPatient.Name = "btnCancelPatient";
            btnCancelPatient.Size = new Size(212, 71);
            btnCancelPatient.TabIndex = 109;
            btnCancelPatient.Text = "Cancel";
            btnCancelPatient.TextAlign = ContentAlignment.MiddleRight;
            btnCancelPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelPatient.UseVisualStyleBackColor = false;
            btnCancelPatient.Click += btnCancelPatient_Click;
            // 
            // btnConfirmPatient
            // 
            btnConfirmPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmPatient.BackColor = Color.FromArgb(73, 80, 87);
            btnConfirmPatient.Cursor = Cursors.Hand;
            btnConfirmPatient.FlatAppearance.BorderSize = 0;
            btnConfirmPatient.FlatStyle = FlatStyle.Flat;
            btnConfirmPatient.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmPatient.ForeColor = Color.White;
            btnConfirmPatient.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnConfirmPatient.IconColor = Color.White;
            btnConfirmPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmPatient.Location = new Point(301, 511);
            btnConfirmPatient.Margin = new Padding(3, 4, 3, 4);
            btnConfirmPatient.Name = "btnConfirmPatient";
            btnConfirmPatient.Size = new Size(218, 71);
            btnConfirmPatient.TabIndex = 113;
            btnConfirmPatient.Text = "Confirm";
            btnConfirmPatient.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfirmPatient.UseVisualStyleBackColor = false;
            btnConfirmPatient.Visible = false;
            btnConfirmPatient.Click += btnConfirmPatient_Click_1;
            // 
            // btnEditPatient
            // 
            btnEditPatient.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditPatient.BackColor = Color.FromArgb(73, 80, 87);
            btnEditPatient.Cursor = Cursors.Hand;
            btnEditPatient.FlatAppearance.BorderSize = 0;
            btnEditPatient.FlatStyle = FlatStyle.Flat;
            btnEditPatient.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditPatient.ForeColor = Color.White;
            btnEditPatient.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnEditPatient.IconColor = Color.White;
            btnEditPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditPatient.IconSize = 35;
            btnEditPatient.Location = new Point(301, 511);
            btnEditPatient.Margin = new Padding(3, 4, 3, 4);
            btnEditPatient.Name = "btnEditPatient";
            btnEditPatient.Size = new Size(218, 71);
            btnEditPatient.TabIndex = 112;
            btnEditPatient.Text = "Edit";
            btnEditPatient.TextAlign = ContentAlignment.MiddleRight;
            btnEditPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditPatient.UseVisualStyleBackColor = false;
            btnEditPatient.Click += btnEditPatient_Click_1;
            // 
            // FormPatientDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 601);
            Controls.Add(btnConfirmPatient);
            Controls.Add(btnEditPatient);
            Controls.Add(btnCancelPatient);
            Controls.Add(comboBoxActiveStatusPatient);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(textBoxPeselPatient);
            Controls.Add(label3);
            Controls.Add(textBoxLastNamePatient);
            Controls.Add(label2);
            Controls.Add(textBoxFirstNamePatient);
            Controls.Add(label1);
            Name = "FormPatientDetails";
            Text = "Patient details";
            Load += FormPatientDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxActiveStatusPatient;
        private Label label13;
        private Label label10;
        private TextBox textBoxPeselPatient;
        private Label label3;
        private TextBox textBoxLastNamePatient;
        private Label label2;
        private TextBox textBoxFirstNamePatient;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCancelPatient;
        private FontAwesome.Sharp.IconButton btnConfirmPatient;
        private FontAwesome.Sharp.IconButton btnEditPatient;
    }
}