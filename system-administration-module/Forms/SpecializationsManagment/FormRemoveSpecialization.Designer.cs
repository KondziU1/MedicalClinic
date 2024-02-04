namespace SystemAdministrationModule.Forms.SpecializationsManagment
{
    partial class FormRemoveSpecialization
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
            btnCancel = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            btnDelete = new FontAwesome.Sharp.IconButton();
            textBoxSpecializationName = new TextBox();
            label1 = new Label();
            SuspendLayout();
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
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancel.IconColor = Color.White;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(346, 111);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 58);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(43, 9);
            label10.Name = "label10";
            label10.Size = new Size(592, 29);
            label10.TabIndex = 46;
            label10.Text = "Are you sure to remove this specialization?";
            label10.Click += label10_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.BackColor = Color.FromArgb(73, 80, 87);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnDelete.IconColor = Color.White;
            btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDelete.Location = new Point(175, 111);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 58);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBoxSpecializationName
            // 
            textBoxSpecializationName.BackColor = Color.White;
            textBoxSpecializationName.Enabled = false;
            textBoxSpecializationName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSpecializationName.Location = new Point(297, 61);
            textBoxSpecializationName.Name = "textBoxSpecializationName";
            textBoxSpecializationName.Size = new Size(200, 29);
            textBoxSpecializationName.TabIndex = 44;
            textBoxSpecializationName.TextChanged += textBoxSpecializationName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 64);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 43;
            label1.Text = "Specialization Name";
            label1.Click += label1_Click;
            // 
            // FormRemoveSpecialization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 181);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(label10);
            Controls.Add(btnDelete);
            Controls.Add(textBoxSpecializationName);
            Controls.Add(label1);
            Name = "FormRemoveSpecialization";
            Text = "Remove specialization";
            Load += FormRemoveSpecialization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCancel;
        private Label label10;
        private FontAwesome.Sharp.IconButton btnDelete;
        private TextBox textBoxSpecializationName;
        private Label label1;
    }
}