namespace SystemAdministrationModule.Forms.DoctorModule
{
    partial class FormVisitHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPatientHistory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeperiod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnComment = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatientHistory
            // 
            this.dataGridViewPatientHistory.AllowUserToAddRows = false;
            this.dataGridViewPatientHistory.AllowUserToDeleteRows = false;
            this.dataGridViewPatientHistory.AllowUserToResizeColumns = false;
            this.dataGridViewPatientHistory.AllowUserToResizeRows = false;
            this.dataGridViewPatientHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPatientHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPatientHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPatientHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatientHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPatientHistory.ColumnHeadersHeight = 55;
            this.dataGridViewPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPatientHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.timeperiod,
            this.PESEL,
            this.Status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatientHistory.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPatientHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewPatientHistory.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewPatientHistory.Name = "dataGridViewPatientHistory";
            this.dataGridViewPatientHistory.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatientHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPatientHistory.RowHeadersVisible = false;
            this.dataGridViewPatientHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPatientHistory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dataGridViewPatientHistory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewPatientHistory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPatientHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.dataGridViewPatientHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPatientHistory.RowTemplate.Height = 55;
            this.dataGridViewPatientHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPatientHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatientHistory.Size = new System.Drawing.Size(1268, 500);
            this.dataGridViewPatientHistory.TabIndex = 7;
            this.dataGridViewPatientHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientHistory_CellDoubleClick);
            this.dataGridViewPatientHistory.SelectionChanged += new System.EventHandler(this.dataGridViewPatientHistory_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Date
            // 
            this.Date.FillWeight = 84.59519F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 317;
            // 
            // timeperiod
            // 
            this.timeperiod.FillWeight = 85.91282F;
            this.timeperiod.HeaderText = "Time period";
            this.timeperiod.Name = "timeperiod";
            this.timeperiod.ReadOnly = true;
            this.timeperiod.Width = 322;
            // 
            // PESEL
            // 
            this.PESEL.FillWeight = 85.05426F;
            this.PESEL.HeaderText = "Doctor";
            this.PESEL.Name = "PESEL";
            this.PESEL.ReadOnly = true;
            this.PESEL.Width = 319;
            // 
            // Status
            // 
            this.Status.FillWeight = 82.2848F;
            this.Status.HeaderText = "Office";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 308;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 29);
            this.label3.TabIndex = 65;
            this.label3.Text = "Visit History";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(1244, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 29);
            this.btnClose.TabIndex = 68;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnComment
            // 
            this.btnComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComment.FlatAppearance.BorderSize = 0;
            this.btnComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComment.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComment.ForeColor = System.Drawing.Color.White;
            this.btnComment.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btnComment.IconColor = System.Drawing.Color.White;
            this.btnComment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComment.IconSize = 35;
            this.btnComment.Location = new System.Drawing.Point(1218, 578);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(62, 52);
            this.btnComment.TabIndex = 69;
            this.btnComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Visible = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // FormVisitHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 642);
            this.ControlBox = false;
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPatientHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVisitHistory";
            this.Text = "Visit History";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dataGridViewPatientHistory;
        private Label label3;
        private FontAwesome.Sharp.IconButton btnClose;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn timeperiod;
        private DataGridViewTextBoxColumn PESEL;
        private DataGridViewTextBoxColumn Status;
        public FontAwesome.Sharp.IconButton btnComment;
    }
}