namespace EquipmentManagementWinform.Forms
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBoxTotalRooms = new System.Windows.Forms.TextBox();
            this.labelTotalRooms = new System.Windows.Forms.Label();
            this.textBoxTotalUsers = new System.Windows.Forms.TextBox();
            this.labelTotalUsers = new System.Windows.Forms.Label();
            this.textBoxTotalRoomEquipments = new System.Windows.Forms.TextBox();
            this.labelTotalRoomEquipments = new System.Windows.Forms.Label();
            this.textBoxTotalEquipments = new System.Windows.Forms.TextBox();
            this.labelTotalEquipments = new System.Windows.Forms.Label();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.labelTotalPageNumber = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.iconButtonNextPage = new FontAwesome.Sharp.IconButton();
            this.iconButtonPreviousPage = new FontAwesome.Sharp.IconButton();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.textBoxPendingBorrowRequest = new System.Windows.Forms.TextBox();
            this.labelPendingBorrowRequest = new System.Windows.Forms.Label();
            this.textBoxPendingRoomBorrowRequest = new System.Windows.Forms.TextBox();
            this.labelPendingRoomBorrowRequest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRooms
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridViewRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRooms.Location = new System.Drawing.Point(48, 86);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersVisible = false;
            this.dataGridViewRooms.Size = new System.Drawing.Size(418, 247);
            this.dataGridViewRooms.TabIndex = 40;
            this.dataGridViewRooms.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRooms.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRooms.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRooms.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRooms.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewRooms.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRooms.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRooms.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewRooms.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridViewRooms.ThemeStyle.ReadOnly = false;
            this.dataGridViewRooms.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRooms.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRooms.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRooms.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewRooms.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewRooms.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRooms.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // textBoxTotalRooms
            // 
            this.textBoxTotalRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalRooms.Location = new System.Drawing.Point(781, 247);
            this.textBoxTotalRooms.Name = "textBoxTotalRooms";
            this.textBoxTotalRooms.Size = new System.Drawing.Size(57, 21);
            this.textBoxTotalRooms.TabIndex = 48;
            // 
            // labelTotalRooms
            // 
            this.labelTotalRooms.AutoSize = true;
            this.labelTotalRooms.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRooms.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalRooms.Location = new System.Drawing.Point(594, 250);
            this.labelTotalRooms.Name = "labelTotalRooms";
            this.labelTotalRooms.Size = new System.Drawing.Size(141, 15);
            this.labelTotalRooms.TabIndex = 47;
            this.labelTotalRooms.Text = "Tổng số phòng học:  ";
            // 
            // textBoxTotalUsers
            // 
            this.textBoxTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalUsers.Location = new System.Drawing.Point(781, 216);
            this.textBoxTotalUsers.Name = "textBoxTotalUsers";
            this.textBoxTotalUsers.Size = new System.Drawing.Size(57, 21);
            this.textBoxTotalUsers.TabIndex = 46;
            // 
            // labelTotalUsers
            // 
            this.labelTotalUsers.AutoSize = true;
            this.labelTotalUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalUsers.Location = new System.Drawing.Point(594, 219);
            this.labelTotalUsers.Name = "labelTotalUsers";
            this.labelTotalUsers.Size = new System.Drawing.Size(146, 15);
            this.labelTotalUsers.TabIndex = 45;
            this.labelTotalUsers.Text = "Tổng số người dùng:  ";
            // 
            // textBoxTotalRoomEquipments
            // 
            this.textBoxTotalRoomEquipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalRoomEquipments.Location = new System.Drawing.Point(781, 312);
            this.textBoxTotalRoomEquipments.Name = "textBoxTotalRoomEquipments";
            this.textBoxTotalRoomEquipments.Size = new System.Drawing.Size(57, 21);
            this.textBoxTotalRoomEquipments.TabIndex = 52;
            // 
            // labelTotalRoomEquipments
            // 
            this.labelTotalRoomEquipments.AutoSize = true;
            this.labelTotalRoomEquipments.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalRoomEquipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRoomEquipments.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalRoomEquipments.Location = new System.Drawing.Point(594, 315);
            this.labelTotalRoomEquipments.Name = "labelTotalRoomEquipments";
            this.labelTotalRoomEquipments.Size = new System.Drawing.Size(187, 15);
            this.labelTotalRoomEquipments.TabIndex = 51;
            this.labelTotalRoomEquipments.Text = "Số thiết bị được phân phối:  ";
            // 
            // textBoxTotalEquipments
            // 
            this.textBoxTotalEquipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalEquipments.Location = new System.Drawing.Point(781, 281);
            this.textBoxTotalEquipments.Name = "textBoxTotalEquipments";
            this.textBoxTotalEquipments.Size = new System.Drawing.Size(57, 21);
            this.textBoxTotalEquipments.TabIndex = 50;
            // 
            // labelTotalEquipments
            // 
            this.labelTotalEquipments.AutoSize = true;
            this.labelTotalEquipments.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalEquipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalEquipments.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalEquipments.Location = new System.Drawing.Point(594, 284);
            this.labelTotalEquipments.Name = "labelTotalEquipments";
            this.labelTotalEquipments.Size = new System.Drawing.Size(118, 15);
            this.labelTotalEquipments.TabIndex = 49;
            this.labelTotalEquipments.Text = "Tổng số thiết bị:  ";
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.Lavender;
            this.homeButton.Image = global::EquipmentManagementWinform.Properties.Resources.Logo_Trường_Đại_Học_Sư_Phạm_Kỹ_Thuật_TP_Hồ_Chí_Minh;
            this.homeButton.Location = new System.Drawing.Point(604, 23);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(282, 156);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 53;
            this.homeButton.TabStop = false;
            // 
            // labelTotalPageNumber
            // 
            this.labelTotalPageNumber.AutoSize = true;
            this.labelTotalPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalPageNumber.Location = new System.Drawing.Point(257, 349);
            this.labelTotalPageNumber.Name = "labelTotalPageNumber";
            this.labelTotalPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelTotalPageNumber.TabIndex = 58;
            this.labelTotalPageNumber.Text = "1";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSlash.Location = new System.Drawing.Point(238, 349);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(13, 17);
            this.labelSlash.TabIndex = 57;
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
            this.iconButtonNextPage.Location = new System.Drawing.Point(303, 339);
            this.iconButtonNextPage.Name = "iconButtonNextPage";
            this.iconButtonNextPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonNextPage.TabIndex = 56;
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
            this.iconButtonPreviousPage.Location = new System.Drawing.Point(148, 339);
            this.iconButtonPreviousPage.Name = "iconButtonPreviousPage";
            this.iconButtonPreviousPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonPreviousPage.TabIndex = 55;
            this.iconButtonPreviousPage.UseVisualStyleBackColor = true;
            this.iconButtonPreviousPage.Click += new System.EventHandler(this.iconButtonPreviousPage_Click);
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPageNumber.Location = new System.Drawing.Point(215, 349);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelPageNumber.TabIndex = 54;
            this.labelPageNumber.Text = "1";
            // 
            // textBoxPendingBorrowRequest
            // 
            this.textBoxPendingBorrowRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPendingBorrowRequest.Location = new System.Drawing.Point(705, 379);
            this.textBoxPendingBorrowRequest.Name = "textBoxPendingBorrowRequest";
            this.textBoxPendingBorrowRequest.Size = new System.Drawing.Size(57, 21);
            this.textBoxPendingBorrowRequest.TabIndex = 60;
            // 
            // labelPendingBorrowRequest
            // 
            this.labelPendingBorrowRequest.AutoSize = true;
            this.labelPendingBorrowRequest.BackColor = System.Drawing.Color.Transparent;
            this.labelPendingBorrowRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendingBorrowRequest.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPendingBorrowRequest.Location = new System.Drawing.Point(420, 382);
            this.labelPendingBorrowRequest.Name = "labelPendingBorrowRequest";
            this.labelPendingBorrowRequest.Size = new System.Drawing.Size(263, 15);
            this.labelPendingBorrowRequest.TabIndex = 59;
            this.labelPendingBorrowRequest.Text = "Số phiểu mượn thiết bị chưa được xử lý: ";
            // 
            // textBoxPendingRoomBorrowRequest
            // 
            this.textBoxPendingRoomBorrowRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPendingRoomBorrowRequest.Location = new System.Drawing.Point(705, 417);
            this.textBoxPendingRoomBorrowRequest.Name = "textBoxPendingRoomBorrowRequest";
            this.textBoxPendingRoomBorrowRequest.Size = new System.Drawing.Size(57, 21);
            this.textBoxPendingRoomBorrowRequest.TabIndex = 62;
            // 
            // labelPendingRoomBorrowRequest
            // 
            this.labelPendingRoomBorrowRequest.AutoSize = true;
            this.labelPendingRoomBorrowRequest.BackColor = System.Drawing.Color.Transparent;
            this.labelPendingRoomBorrowRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendingRoomBorrowRequest.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPendingRoomBorrowRequest.Location = new System.Drawing.Point(420, 420);
            this.labelPendingRoomBorrowRequest.Name = "labelPendingRoomBorrowRequest";
            this.labelPendingRoomBorrowRequest.Size = new System.Drawing.Size(259, 15);
            this.labelPendingRoomBorrowRequest.TabIndex = 61;
            this.labelPendingRoomBorrowRequest.Text = "Số phiểu mượn phòng chưa được xử lý: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ứng dụng quản lý phòng học và thiết bị";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPendingRoomBorrowRequest);
            this.Controls.Add(this.labelPendingRoomBorrowRequest);
            this.Controls.Add(this.textBoxPendingBorrowRequest);
            this.Controls.Add(this.labelPendingBorrowRequest);
            this.Controls.Add(this.labelTotalPageNumber);
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.iconButtonNextPage);
            this.Controls.Add(this.iconButtonPreviousPage);
            this.Controls.Add(this.labelPageNumber);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.textBoxTotalRoomEquipments);
            this.Controls.Add(this.labelTotalRoomEquipments);
            this.Controls.Add(this.textBoxTotalEquipments);
            this.Controls.Add(this.labelTotalEquipments);
            this.Controls.Add(this.textBoxTotalRooms);
            this.Controls.Add(this.labelTotalRooms);
            this.Controls.Add(this.textBoxTotalUsers);
            this.Controls.Add(this.labelTotalUsers);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "Home";
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRooms;
        private System.Windows.Forms.TextBox textBoxTotalRooms;
        private System.Windows.Forms.Label labelTotalRooms;
        private System.Windows.Forms.TextBox textBoxTotalUsers;
        private System.Windows.Forms.Label labelTotalUsers;
        private System.Windows.Forms.TextBox textBoxTotalRoomEquipments;
        private System.Windows.Forms.Label labelTotalRoomEquipments;
        private System.Windows.Forms.TextBox textBoxTotalEquipments;
        private System.Windows.Forms.Label labelTotalEquipments;
        private System.Windows.Forms.PictureBox homeButton;
        public System.Windows.Forms.Label labelTotalPageNumber;
        private System.Windows.Forms.Label labelSlash;
        private FontAwesome.Sharp.IconButton iconButtonNextPage;
        private FontAwesome.Sharp.IconButton iconButtonPreviousPage;
        public System.Windows.Forms.Label labelPageNumber;
        private System.Windows.Forms.TextBox textBoxPendingBorrowRequest;
        private System.Windows.Forms.Label labelPendingBorrowRequest;
        private System.Windows.Forms.TextBox textBoxPendingRoomBorrowRequest;
        private System.Windows.Forms.Label labelPendingRoomBorrowRequest;
        private System.Windows.Forms.Label label1;
    }
}