namespace SystemAdministrationModule.Forms.DoctorModule
{
    partial class FormVisitDetails
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
            this.btnRejectOrComment = new FontAwesome.Sharp.IconButton();
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOffice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVisitStartTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVisitEndTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnRejectOrComment
            // 
            this.btnRejectOrComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRejectOrComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnRejectOrComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRejectOrComment.FlatAppearance.BorderSize = 0;
            this.btnRejectOrComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectOrComment.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRejectOrComment.ForeColor = System.Drawing.Color.White;
            this.btnRejectOrComment.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnRejectOrComment.IconColor = System.Drawing.Color.White;
            this.btnRejectOrComment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRejectOrComment.IconSize = 35;
            this.btnRejectOrComment.Location = new System.Drawing.Point(103, 277);
            this.btnRejectOrComment.Name = "btnRejectOrComment";
            this.btnRejectOrComment.Size = new System.Drawing.Size(197, 60);
            this.btnRejectOrComment.TabIndex = 63;
            this.btnRejectOrComment.Text = "Reject visit";
            this.btnRejectOrComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRejectOrComment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRejectOrComment.UseVisualStyleBackColor = false;
            this.btnRejectOrComment.Click += new System.EventHandler(this.btnRejectOrComment_Click);
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.BackColor = System.Drawing.Color.White;
            this.textBoxPesel.Enabled = false;
            this.textBoxPesel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPesel.Location = new System.Drawing.Point(103, 215);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.ReadOnly = true;
            this.textBoxPesel.Size = new System.Drawing.Size(197, 29);
            this.textBoxPesel.TabIndex = 69;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(103, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 68;
            this.label4.Text = "PESEL";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.White;
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(103, 158);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(197, 29);
            this.textBoxLastName.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 66;
            this.label3.Text = "Last name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.White;
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(103, 93);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(197, 29);
            this.textBoxFirstName.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 64;
            this.label2.Text = "First name";
            // 
            // textBoxOffice
            // 
            this.textBoxOffice.BackColor = System.Drawing.Color.White;
            this.textBoxOffice.Enabled = false;
            this.textBoxOffice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOffice.Location = new System.Drawing.Point(336, 215);
            this.textBoxOffice.Name = "textBoxOffice";
            this.textBoxOffice.ReadOnly = true;
            this.textBoxOffice.Size = new System.Drawing.Size(197, 29);
            this.textBoxOffice.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(336, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Office ";
            // 
            // textBoxVisitStartTime
            // 
            this.textBoxVisitStartTime.BackColor = System.Drawing.Color.White;
            this.textBoxVisitStartTime.Enabled = false;
            this.textBoxVisitStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVisitStartTime.Location = new System.Drawing.Point(336, 93);
            this.textBoxVisitStartTime.Name = "textBoxVisitStartTime";
            this.textBoxVisitStartTime.ReadOnly = true;
            this.textBoxVisitStartTime.Size = new System.Drawing.Size(197, 29);
            this.textBoxVisitStartTime.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(336, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 72;
            this.label6.Text = "Start of the visit";
            // 
            // textBoxVisitEndTime
            // 
            this.textBoxVisitEndTime.BackColor = System.Drawing.Color.White;
            this.textBoxVisitEndTime.Enabled = false;
            this.textBoxVisitEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVisitEndTime.Location = new System.Drawing.Point(336, 158);
            this.textBoxVisitEndTime.Name = "textBoxVisitEndTime";
            this.textBoxVisitEndTime.ReadOnly = true;
            this.textBoxVisitEndTime.Size = new System.Drawing.Size(197, 29);
            this.textBoxVisitEndTime.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(336, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 74;
            this.label7.Text = "End of the visit";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(236, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 29);
            this.labelTitle.TabIndex = 76;
            this.labelTitle.Text = "Visit details";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 35;
            this.btnCancel.Location = new System.Drawing.Point(336, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 60);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormVisitDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(636, 370);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxVisitEndTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxVisitStartTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxOffice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPesel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRejectOrComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormVisitDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit Details";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxPesel;
        private Label label4;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxOffice;
        private Label label5;
        private TextBox textBoxVisitStartTime;
        private Label label6;
        private TextBox textBoxVisitEndTime;
        private Label label7;
        private Label labelTitle;
        private FontAwesome.Sharp.IconButton btnCancel;
        public FontAwesome.Sharp.IconButton btnRejectOrComment;
    }
}