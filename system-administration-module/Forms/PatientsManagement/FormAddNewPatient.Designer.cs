namespace SystemAdministrationModule.Forms.PatientsManagement
{
    partial class FormAddNewPatient
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
            btnCancelPatient = new FontAwesome.Sharp.IconButton();
            textBoxPeselPatient = new TextBox();
            label3 = new Label();
            textBoxLastNamePatient = new TextBox();
            label2 = new Label();
            textBoxFirstNamePatient = new TextBox();
            label1 = new Label();
            label10 = new Label();
            btnAdd = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
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
            btnCancelPatient.Location = new Point(21, 328);
            btnCancelPatient.Name = "btnCancelPatient";
            btnCancelPatient.Size = new Size(200, 58);
            btnCancelPatient.TabIndex = 43;
            btnCancelPatient.Text = "Cancel";
            btnCancelPatient.TextAlign = ContentAlignment.MiddleRight;
            btnCancelPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelPatient.UseVisualStyleBackColor = false;
            btnCancelPatient.Click += btnCancelPatient_Click;
            // 
            // textBoxPeselPatient
            // 
            textBoxPeselPatient.BackColor = Color.White;
            textBoxPeselPatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPeselPatient.Location = new Point(21, 262);
            textBoxPeselPatient.Name = "textBoxPeselPatient";
            textBoxPeselPatient.Size = new Size(424, 29);
            textBoxPeselPatient.TabIndex = 29;
            textBoxPeselPatient.TextChanged += textBoxPeselPatient_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 238);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 28;
            label3.Text = "PESEL";
            // 
            // textBoxLastNamePatient
            // 
            textBoxLastNamePatient.BackColor = Color.White;
            textBoxLastNamePatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastNamePatient.Location = new Point(21, 191);
            textBoxLastNamePatient.Name = "textBoxLastNamePatient";
            textBoxLastNamePatient.Size = new Size(424, 29);
            textBoxLastNamePatient.TabIndex = 27;
            textBoxLastNamePatient.TextChanged += textBoxLastNamePatient_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 165);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 26;
            label2.Text = "Last Name";
            // 
            // textBoxFirstNamePatient
            // 
            textBoxFirstNamePatient.BackColor = Color.White;
            textBoxFirstNamePatient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstNamePatient.Location = new Point(21, 122);
            textBoxFirstNamePatient.Name = "textBoxFirstNamePatient";
            textBoxFirstNamePatient.Size = new Size(424, 29);
            textBoxFirstNamePatient.TabIndex = 25;
            textBoxFirstNamePatient.TextChanged += textBoxFirstNamePatient_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 98);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 24;
            label1.Text = "First Name";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(115, 41);
            label10.Name = "label10";
            label10.Size = new Size(259, 29);
            label10.TabIndex = 44;
            label10.Text = "Add a new patient";
            label10.Click += label10_Click;
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
            btnAdd.Location = new Point(245, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 58);
            btnAdd.TabIndex = 45;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormAddNewPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 426);
            Controls.Add(btnAdd);
            Controls.Add(label10);
            Controls.Add(btnCancelPatient);
            Controls.Add(textBoxPeselPatient);
            Controls.Add(label3);
            Controls.Add(textBoxLastNamePatient);
            Controls.Add(label2);
            Controls.Add(textBoxFirstNamePatient);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddNewPatient";
            Text = "Add new patient";
            Load += FormAddNewPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancelPatient;
        public TextBox textBoxPeselPatient;
        private Label label3;
        public TextBox textBoxLastNamePatient;
        private Label label2;
        public TextBox textBoxFirstNamePatient;
        private Label label1;
        private Label label10;
        public FontAwesome.Sharp.IconButton btnAdd;
    }
}