namespace EquipmentManagementWinform.Forms
{
    partial class RoomBorrowRequestManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBorrowRequest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelTotalPageNumber = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.iconButtonNextPage = new FontAwesome.Sharp.IconButton();
            this.iconButtonPreviousPage = new FontAwesome.Sharp.IconButton();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonReturned = new System.Windows.Forms.Button();
            this.textBoxRoomId = new System.Windows.Forms.TextBox();
            this.labelRoomId = new System.Windows.Forms.Label();
            this.textBoxReturnDate = new System.Windows.Forms.TextBox();
            this.labelReturnDate = new System.Windows.Forms.Label();
            this.textBoxBorrowDate = new System.Windows.Forms.TextBox();
            this.labelBorrowDate = new System.Windows.Forms.Label();
            this.textBoxRequestDate = new System.Windows.Forms.TextBox();
            this.labelRequestDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrowRequest
            // 
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.dataGridViewBorrowRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBorrowRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewBorrowRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBorrowRequest.DefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewBorrowRequest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBorrowRequest.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewBorrowRequest.Name = "dataGridViewBorrowRequest";
            this.dataGridViewBorrowRequest.ReadOnly = true;
            this.dataGridViewBorrowRequest.RowHeadersVisible = false;
            this.dataGridViewBorrowRequest.Size = new System.Drawing.Size(945, 276);
            this.dataGridViewBorrowRequest.TabIndex = 3;
            this.dataGridViewBorrowRequest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBorrowRequest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewBorrowRequest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewBorrowRequest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewBorrowRequest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewBorrowRequest.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBorrowRequest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBorrowRequest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewBorrowRequest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewBorrowRequest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBorrowRequest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewBorrowRequest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewBorrowRequest.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridViewBorrowRequest.ThemeStyle.ReadOnly = true;
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewBorrowRequest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(586, 304);
            this.labelStatus.MaximumSize = new System.Drawing.Size(300, 50);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 20);
            this.labelStatus.TabIndex = 67;
            // 
            // labelTotalPageNumber
            // 
            this.labelTotalPageNumber.AutoSize = true;
            this.labelTotalPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalPageNumber.Location = new System.Drawing.Point(470, 304);
            this.labelTotalPageNumber.Name = "labelTotalPageNumber";
            this.labelTotalPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelTotalPageNumber.TabIndex = 66;
            this.labelTotalPageNumber.Text = "1";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSlash.Location = new System.Drawing.Point(451, 304);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(13, 17);
            this.labelSlash.TabIndex = 65;
            this.labelSlash.Text = "/";
            // 
            // iconButtonNextPage
            // 
            this.iconButtonNextPage.FlatAppearance.BorderSize = 0;
            this.iconButtonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNextPage.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iconButtonNextPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconButtonNextPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNextPage.IconSize = 28;
            this.iconButtonNextPage.Location = new System.Drawing.Point(516, 294);
            this.iconButtonNextPage.Name = "iconButtonNextPage";
            this.iconButtonNextPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonNextPage.TabIndex = 64;
            this.iconButtonNextPage.UseVisualStyleBackColor = true;
            this.iconButtonNextPage.Click += new System.EventHandler(this.iconButtonNextPage_Click);
            // 
            // iconButtonPreviousPage
            // 
            this.iconButtonPreviousPage.FlatAppearance.BorderSize = 0;
            this.iconButtonPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPreviousPage.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButtonPreviousPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconButtonPreviousPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPreviousPage.IconSize = 28;
            this.iconButtonPreviousPage.Location = new System.Drawing.Point(361, 294);
            this.iconButtonPreviousPage.Name = "iconButtonPreviousPage";
            this.iconButtonPreviousPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonPreviousPage.TabIndex = 63;
            this.iconButtonPreviousPage.UseVisualStyleBackColor = true;
            this.iconButtonPreviousPage.Click += new System.EventHandler(this.iconButtonPreviousPage_Click);
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPageNumber.Location = new System.Drawing.Point(428, 304);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelPageNumber.TabIndex = 62;
            this.labelPageNumber.Text = "1";
            // 
            // buttonReject
            // 
            this.buttonReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.Location = new System.Drawing.Point(555, 385);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(170, 40);
            this.buttonReject.TabIndex = 70;
            this.buttonReject.Text = "Từ chối";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Visible = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonApprove
            // 
            this.buttonApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApprove.Location = new System.Drawing.Point(759, 385);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(170, 40);
            this.buttonApprove.TabIndex = 69;
            this.buttonApprove.Text = "Chấp nhận";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Visible = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
            // 
            // buttonReturned
            // 
            this.buttonReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturned.Location = new System.Drawing.Point(652, 345);
            this.buttonReturned.Name = "buttonReturned";
            this.buttonReturned.Size = new System.Drawing.Size(152, 66);
            this.buttonReturned.TabIndex = 68;
            this.buttonReturned.Text = "Đánh dấu thiết bị này đã được trả";
            this.buttonReturned.UseVisualStyleBackColor = true;
            this.buttonReturned.Visible = false;
            this.buttonReturned.Click += new System.EventHandler(this.buttonReturned_Click);
            // 
            // textBoxRoomId
            // 
            this.textBoxRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomId.Location = new System.Drawing.Point(431, 339);
            this.textBoxRoomId.Name = "textBoxRoomId";
            this.textBoxRoomId.ReadOnly = true;
            this.textBoxRoomId.Size = new System.Drawing.Size(56, 21);
            this.textBoxRoomId.TabIndex = 78;
            // 
            // labelRoomId
            // 
            this.labelRoomId.AutoSize = true;
            this.labelRoomId.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomId.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRoomId.Location = new System.Drawing.Point(310, 342);
            this.labelRoomId.Name = "labelRoomId";
            this.labelRoomId.Size = new System.Drawing.Size(70, 15);
            this.labelRoomId.TabIndex = 77;
            this.labelRoomId.Text = "ID Phòng:";
            // 
            // textBoxReturnDate
            // 
            this.textBoxReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReturnDate.Location = new System.Drawing.Point(150, 421);
            this.textBoxReturnDate.Name = "textBoxReturnDate";
            this.textBoxReturnDate.ReadOnly = true;
            this.textBoxReturnDate.Size = new System.Drawing.Size(117, 21);
            this.textBoxReturnDate.TabIndex = 76;
            // 
            // labelReturnDate
            // 
            this.labelReturnDate.AutoSize = true;
            this.labelReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.labelReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelReturnDate.Location = new System.Drawing.Point(29, 424);
            this.labelReturnDate.Name = "labelReturnDate";
            this.labelReturnDate.Size = new System.Drawing.Size(64, 15);
            this.labelReturnDate.TabIndex = 75;
            this.labelReturnDate.Text = "Ngày trả:";
            // 
            // textBoxBorrowDate
            // 
            this.textBoxBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBorrowDate.Location = new System.Drawing.Point(150, 381);
            this.textBoxBorrowDate.Name = "textBoxBorrowDate";
            this.textBoxBorrowDate.ReadOnly = true;
            this.textBoxBorrowDate.Size = new System.Drawing.Size(117, 21);
            this.textBoxBorrowDate.TabIndex = 74;
            // 
            // labelBorrowDate
            // 
            this.labelBorrowDate.AutoSize = true;
            this.labelBorrowDate.BackColor = System.Drawing.Color.Transparent;
            this.labelBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrowDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBorrowDate.Location = new System.Drawing.Point(29, 384);
            this.labelBorrowDate.Name = "labelBorrowDate";
            this.labelBorrowDate.Size = new System.Drawing.Size(83, 15);
            this.labelBorrowDate.TabIndex = 73;
            this.labelBorrowDate.Text = "Ngày mượn:";
            // 
            // textBoxRequestDate
            // 
            this.textBoxRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRequestDate.Location = new System.Drawing.Point(150, 342);
            this.textBoxRequestDate.Name = "textBoxRequestDate";
            this.textBoxRequestDate.ReadOnly = true;
            this.textBoxRequestDate.Size = new System.Drawing.Size(117, 21);
            this.textBoxRequestDate.TabIndex = 72;
            // 
            // labelRequestDate
            // 
            this.labelRequestDate.AutoSize = true;
            this.labelRequestDate.BackColor = System.Drawing.Color.Transparent;
            this.labelRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRequestDate.Location = new System.Drawing.Point(29, 345);
            this.labelRequestDate.Name = "labelRequestDate";
            this.labelRequestDate.Size = new System.Drawing.Size(96, 15);
            this.labelRequestDate.TabIndex = 71;
            this.labelRequestDate.Text = "Ngày yêu cầu:";
            // 
            // RoomBorrowRequestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.textBoxRoomId);
            this.Controls.Add(this.labelRoomId);
            this.Controls.Add(this.textBoxReturnDate);
            this.Controls.Add(this.labelReturnDate);
            this.Controls.Add(this.textBoxBorrowDate);
            this.Controls.Add(this.labelBorrowDate);
            this.Controls.Add(this.textBoxRequestDate);
            this.Controls.Add(this.labelRequestDate);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.buttonReturned);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTotalPageNumber);
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.iconButtonNextPage);
            this.Controls.Add(this.iconButtonPreviousPage);
            this.Controls.Add(this.labelPageNumber);
            this.Controls.Add(this.dataGridViewBorrowRequest);
            this.Name = "RoomBorrowRequestManagement";
            this.Text = "Quản lý phiếu mượn phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBorrowRequest;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.Label labelTotalPageNumber;
        private System.Windows.Forms.Label labelSlash;
        private FontAwesome.Sharp.IconButton iconButtonNextPage;
        private FontAwesome.Sharp.IconButton iconButtonPreviousPage;
        public System.Windows.Forms.Label labelPageNumber;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.Button buttonReturned;
        private System.Windows.Forms.TextBox textBoxRoomId;
        private System.Windows.Forms.Label labelRoomId;
        private System.Windows.Forms.TextBox textBoxReturnDate;
        private System.Windows.Forms.Label labelReturnDate;
        private System.Windows.Forms.TextBox textBoxBorrowDate;
        private System.Windows.Forms.Label labelBorrowDate;
        private System.Windows.Forms.TextBox textBoxRequestDate;
        private System.Windows.Forms.Label labelRequestDate;
    }
}