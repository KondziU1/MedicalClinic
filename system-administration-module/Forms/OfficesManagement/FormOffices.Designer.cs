namespace SystemAdministrationModule.Forms.OfficesManagement
{
    partial class FormOffices
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnAddOffice = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            dataGridViewOffices = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            number = new DataGridViewTextBoxColumn();
            specialization = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            action = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOffices).BeginInit();
            SuspendLayout();
            // 
            // btnAddOffice
            // 
            btnAddOffice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddOffice.BackColor = Color.FromArgb(73, 80, 87);
            btnAddOffice.Cursor = Cursors.Hand;
            btnAddOffice.FlatAppearance.BorderSize = 0;
            btnAddOffice.FlatStyle = FlatStyle.Flat;
            btnAddOffice.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddOffice.ForeColor = Color.White;
            btnAddOffice.IconChar = FontAwesome.Sharp.IconChar.CirclePlus;
            btnAddOffice.IconColor = Color.White;
            btnAddOffice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddOffice.Location = new Point(33, 940);
            btnAddOffice.Name = "btnAddOffice";
            btnAddOffice.Size = new Size(331, 58);
            btnAddOffice.TabIndex = 7;
            btnAddOffice.Text = "Add new office";
            btnAddOffice.TextAlign = ContentAlignment.MiddleRight;
            btnAddOffice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddOffice.UseVisualStyleBackColor = false;
            btnAddOffice.Click += btnAddOffice_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(105, 29);
            label1.TabIndex = 5;
            label1.Text = "Offices";
            // 
            // dataGridViewOffices
            // 
            dataGridViewOffices.AllowUserToAddRows = false;
            dataGridViewOffices.AllowUserToDeleteRows = false;
            dataGridViewOffices.AllowUserToResizeColumns = false;
            dataGridViewOffices.AllowUserToResizeRows = false;
            dataGridViewOffices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOffices.BackgroundColor = Color.White;
            dataGridViewOffices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewOffices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(73, 80, 87);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOffices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOffices.ColumnHeadersHeight = 55;
            dataGridViewOffices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewOffices.Columns.AddRange(new DataGridViewColumn[] { id, number, specialization, type, status, action, Edit, delete });
            dataGridViewOffices.EnableHeadersVisualStyles = false;
            dataGridViewOffices.Location = new Point(33, 95);
            dataGridViewOffices.Name = "dataGridViewOffices";
            dataGridViewOffices.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewOffices.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewOffices.RowHeadersVisible = false;
            dataGridViewOffices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewOffices.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(233, 236, 239);
            dataGridViewOffices.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewOffices.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewOffices.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 181, 189);
            dataGridViewOffices.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewOffices.RowTemplate.Height = 55;
            dataGridViewOffices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOffices.Size = new Size(1645, 797);
            dataGridViewOffices.TabIndex = 8;
            dataGridViewOffices.CellClick += dataGridViewOffices_CellClick;
            dataGridViewOffices.Paint += dataGridViewOffices_Paint;
            // 
            // id
            // 
            id.FillWeight = 279.187866F;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 50;
            // 
            // number
            // 
            number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            number.FillWeight = 82.0812149F;
            number.HeaderText = "Number";
            number.Name = "number";
            number.ReadOnly = true;
            // 
            // specialization
            // 
            specialization.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            specialization.HeaderText = "Specialization";
            specialization.Name = "specialization";
            specialization.ReadOnly = true;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            type.HeaderText = "Type";
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Status";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // action
            // 
            action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new Padding(10);
            action.DefaultCellStyle = dataGridViewCellStyle2;
            action.HeaderText = "Action";
            action.Name = "action";
            action.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new Padding(10);
            Edit.DefaultCellStyle = dataGridViewCellStyle3;
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Resizable = DataGridViewTriState.True;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Padding = new Padding(10);
            delete.DefaultCellStyle = dataGridViewCellStyle4;
            delete.HeaderText = "Delete";
            delete.Name = "delete";
            delete.ReadOnly = true;
            // 
            // FormOffices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1726, 1026);
            ControlBox = false;
            Controls.Add(dataGridViewOffices);
            Controls.Add(btnAddOffice);
            Controls.Add(label1);
            Name = "FormOffices";
            Text = "Offices";
            Load += FormOffices_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOffices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddOffice;
        private Label label1;
        private DataGridView dataGridViewOffices;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn specialization;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn action;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn delete;
    }
}