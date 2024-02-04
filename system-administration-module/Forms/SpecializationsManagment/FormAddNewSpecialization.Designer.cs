namespace SystemAdministrationModule.Forms.SpecializationsManagment
{
    partial class FormAddNewSpecialization
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
            btnAdd = new FontAwesome.Sharp.IconButton();
            textBoxSpecializationName = new TextBox();
            label1 = new Label();
            btnCancel = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(78, 21);
            label10.Name = "label10";
            label10.Size = new Size(322, 29);
            label10.TabIndex = 41;
            label10.Text = "Add new specialization";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAdd.BackColor = Color.FromArgb(73, 80, 87);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnAdd.IconColor = Color.White;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(78, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 58);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxSpecializationName
            // 
            textBoxSpecializationName.BackColor = Color.White;
            textBoxSpecializationName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSpecializationName.Location = new Point(225, 77);
            textBoxSpecializationName.Name = "textBoxSpecializationName";
            textBoxSpecializationName.Size = new Size(200, 29);
            textBoxSpecializationName.TabIndex = 22;
            textBoxSpecializationName.TextChanged += textBoxSpecializationName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 80);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 21;
            label1.Text = "Specialization Name";
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
            btnCancel.Location = new Point(249, 116);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 58);
            btnCancel.TabIndex = 42;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAddNewSpecialization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 186);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(label10);
            Controls.Add(btnAdd);
            Controls.Add(textBoxSpecializationName);
            Controls.Add(label1);
            Name = "FormAddNewSpecialization";
            Text = "Add new specialization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private FontAwesome.Sharp.IconButton btnAdd;
        private TextBox textBoxSpecializationName;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}