namespace SystemAdministrationModule.Forms.SpecializationsManagment
{
    partial class FormSpecializations
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            btnAddSpecialization = new FontAwesome.Sharp.IconButton();
            dataGridViewSpecializations = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            SpecializationName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Remove = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecializations).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(213, 29);
            label1.TabIndex = 0;
            label1.Text = "Specializations";
            // 
            // btnAddSpecialization
            // 
            btnAddSpecialization.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddSpecialization.BackColor = Color.FromArgb(73, 80, 87);
            btnAddSpecialization.Cursor = Cursors.Hand;
            btnAddSpecialization.FlatAppearance.BorderSize = 0;
            btnAddSpecialization.FlatStyle = FlatStyle.Flat;
            btnAddSpecialization.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddSpecialization.ForeColor = Color.White;
            btnAddSpecialization.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddSpecialization.IconColor = Color.White;
            btnAddSpecialization.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddSpecialization.Location = new Point(35, 917);
            btnAddSpecialization.Name = "btnAddSpecialization";
            btnAddSpecialization.Size = new Size(331, 58);
            btnAddSpecialization.TabIndex = 4;
            btnAddSpecialization.Text = "Add new specialization";
            btnAddSpecialization.TextAlign = ContentAlignment.MiddleRight;
            btnAddSpecialization.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddSpecialization.UseVisualStyleBackColor = false;
            btnAddSpecialization.Click += btnAddSpecialization_Click;
            // 
            // dataGridViewSpecializations
            // 
            dataGridViewSpecializations.AllowUserToAddRows = false;
            dataGridViewSpecializations.AllowUserToDeleteRows = false;
            dataGridViewSpecializations.AllowUserToResizeColumns = false;
            dataGridViewSpecializations.AllowUserToResizeRows = false;
            dataGridViewSpecializations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewSpecializations.BackgroundColor = Color.White;
            dataGridViewSpecializations.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewSpecializations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSpecializations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSpecializations.ColumnHeadersHeight = 55;
            dataGridViewSpecializations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewSpecializations.Columns.AddRange(new DataGridViewColumn[] { id, SpecializationName, Edit, Remove });
            dataGridViewSpecializations.EnableHeadersVisualStyles = false;
            dataGridViewSpecializations.Location = new Point(35, 84);
            dataGridViewSpecializations.Name = "dataGridViewSpecializations";
            dataGridViewSpecializations.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewSpecializations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSpecializations.RowHeadersVisible = false;
            dataGridViewSpecializations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewSpecializations.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewSpecializations.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewSpecializations.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewSpecializations.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewSpecializations.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewSpecializations.RowTemplate.Height = 55;
            dataGridViewSpecializations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSpecializations.Size = new Size(1606, 827);
            dataGridViewSpecializations.TabIndex = 3;
            dataGridViewSpecializations.CellClick += DataGridViewSpecializations_CellClick;
            dataGridViewSpecializations.Paint += dataGridViewSpecializations_Paint;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // SpecializationName
            // 
            SpecializationName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SpecializationName.FillWeight = 150F;
            SpecializationName.HeaderText = "Specialization Name";
            SpecializationName.Name = "SpecializationName";
            SpecializationName.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.FillWeight = 50F;
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.False;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Edit";
            // 
            // Remove
            // 
            Remove.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            Remove.DefaultCellStyle = dataGridViewCellStyle3;
            Remove.FillWeight = 50F;
            Remove.HeaderText = "Remove";
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            // 
            // FormSpecializations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1669, 987);
            Controls.Add(btnAddSpecialization);
            Controls.Add(dataGridViewSpecializations);
            Controls.Add(label1);
            Name = "FormSpecializations";
            Text = "Specializations";
            Load += FormSpecializations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSpecializations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private FontAwesome.Sharp.IconButton btnAddSpecialization;
        private DataGridView dataGridViewSpecializations;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn SpecializationName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Remove;
    }
}