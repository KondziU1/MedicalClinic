namespace SystemAdministrationModule.Forms.Settings
{
    partial class FormSettings
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
            btnSave = new FontAwesome.Sharp.IconButton();
            textBoxTimeBlocking = new TextBox();
            label1 = new Label();
            textBoxInactive = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(73, 80, 87);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnSave.IconColor = Color.White;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(508, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(206, 58);
            btnSave.TabIndex = 62;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBoxTimeBlocking
            // 
            textBoxTimeBlocking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTimeBlocking.Location = new Point(508, 128);
            textBoxTimeBlocking.Name = "textBoxTimeBlocking";
            textBoxTimeBlocking.Size = new Size(197, 23);
            textBoxTimeBlocking.TabIndex = 68;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(508, 104);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 67;
            label1.Text = "Time Blocking Login Value";
            // 
            // textBoxInactive
            // 
            textBoxInactive.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxInactive.Location = new Point(508, 178);
            textBoxInactive.Name = "textBoxInactive";
            textBoxInactive.Size = new Size(197, 23);
            textBoxInactive.TabIndex = 70;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(508, 154);
            label2.Name = "label2";
            label2.Size = new Size(206, 21);
            label2.TabIndex = 69;
            label2.Text = "Time Blocking Inactive Value";
            // 
            // FormSettings
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1211, 452);
            Controls.Add(textBoxInactive);
            Controls.Add(label2);
            Controls.Add(textBoxTimeBlocking);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "FormSettings";
            Text = "Form1";
            Load += FormSettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton btnSave;
        private ComboBox comboBox1;
        private TextBox textBoxTimeBlocking;
        private Label label1;
        private TextBox textBoxInactive;
        private Label label2;
    }
}