namespace EquipmentManagementWinform.Forms
{
    partial class RoomManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTotalPageNumber = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.iconButtonNextPage = new FontAwesome.Sharp.IconButton();
            this.iconButtonPreviousPage = new FontAwesome.Sharp.IconButton();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.dataGridViewRooms = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewRoomEquipments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.iconButtonAddRoom = new FontAwesome.Sharp.IconButton();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomEquipments)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalPageNumber
            // 
            this.labelTotalPageNumber.AutoSize = true;
            this.labelTotalPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalPageNumber.Location = new System.Drawing.Point(160, 364);
            this.labelTotalPageNumber.Name = "labelTotalPageNumber";
            this.labelTotalPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelTotalPageNumber.TabIndex = 44;
            this.labelTotalPageNumber.Text = "1";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSlash.Location = new System.Drawing.Point(141, 364);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(13, 17);
            this.labelSlash.TabIndex = 43;
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
            this.iconButtonNextPage.Location = new System.Drawing.Point(206, 354);
            this.iconButtonNextPage.Name = "iconButtonNextPage";
            this.iconButtonNextPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonNextPage.TabIndex = 42;
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
            this.iconButtonPreviousPage.Location = new System.Drawing.Point(51, 354);
            this.iconButtonPreviousPage.Name = "iconButtonPreviousPage";
            this.iconButtonPreviousPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonPreviousPage.TabIndex = 41;
            this.iconButtonPreviousPage.UseVisualStyleBackColor = true;
            this.iconButtonPreviousPage.Click += new System.EventHandler(this.iconButtonPreviousPage_Click);
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPageNumber.Location = new System.Drawing.Point(118, 364);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelPageNumber.TabIndex = 40;
            this.labelPageNumber.Text = "1";
            // 
            // dataGridViewRooms
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewRooms.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRooms.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersVisible = false;
            this.dataGridViewRooms.Size = new System.Drawing.Size(289, 247);
            this.dataGridViewRooms.TabIndex = 39;
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
            // dataGridViewRoomEquipments
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridViewRoomEquipments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoomEquipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRoomEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoomEquipments.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRoomEquipments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRoomEquipments.Location = new System.Drawing.Point(442, 91);
            this.dataGridViewRoomEquipments.Name = "dataGridViewRoomEquipments";
            this.dataGridViewRoomEquipments.RowHeadersVisible = false;
            this.dataGridViewRoomEquipments.Size = new System.Drawing.Size(467, 247);
            this.dataGridViewRoomEquipments.TabIndex = 45;
            this.dataGridViewRoomEquipments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRoomEquipments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewRoomEquipments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRoomEquipments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewRoomEquipments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewRoomEquipments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRoomEquipments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRoomEquipments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewRoomEquipments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewRoomEquipments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoomEquipments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewRoomEquipments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewRoomEquipments.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridViewRoomEquipments.ThemeStyle.ReadOnly = false;
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewRoomEquipments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // iconButtonAddRoom
            // 
            this.iconButtonAddRoom.FlatAppearance.BorderSize = 0;
            this.iconButtonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddRoom.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddRoom.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconButtonAddRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddRoom.Location = new System.Drawing.Point(307, 91);
            this.iconButtonAddRoom.Name = "iconButtonAddRoom";
            this.iconButtonAddRoom.Size = new System.Drawing.Size(75, 66);
            this.iconButtonAddRoom.TabIndex = 46;
            this.iconButtonAddRoom.UseVisualStyleBackColor = true;
            this.iconButtonAddRoom.Click += new System.EventHandler(this.iconButtonAddRoom_Click);
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomName.Location = new System.Drawing.Point(348, 417);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(177, 21);
            this.textBoxRoomName.TabIndex = 48;
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.BackColor = System.Drawing.Color.Transparent;
            this.labelRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRoomName.Location = new System.Drawing.Point(259, 420);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(83, 15);
            this.labelRoomName.TabIndex = 47;
            this.labelRoomName.Text = "Tên phòng: ";
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditRoom.Location = new System.Drawing.Point(559, 417);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(101, 21);
            this.buttonEditRoom.TabIndex = 49;
            this.buttonEditRoom.Text = "Sửa";
            this.buttonEditRoom.UseVisualStyleBackColor = true;
            this.buttonEditRoom.Visible = false;
            this.buttonEditRoom.Click += new System.EventHandler(this.buttonEditRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(439, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Các thiết bị có trong phòng: ";
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditRoom);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.iconButtonAddRoom);
            this.Controls.Add(this.dataGridViewRoomEquipments);
            this.Controls.Add(this.labelTotalPageNumber);
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.iconButtonNextPage);
            this.Controls.Add(this.iconButtonPreviousPage);
            this.Controls.Add(this.labelPageNumber);
            this.Controls.Add(this.dataGridViewRooms);
            this.Name = "RoomManagement";
            this.Text = "Quản lý phòng học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomEquipments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelTotalPageNumber;
        private System.Windows.Forms.Label labelSlash;
        private FontAwesome.Sharp.IconButton iconButtonNextPage;
        private FontAwesome.Sharp.IconButton iconButtonPreviousPage;
        public System.Windows.Forms.Label labelPageNumber;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRooms;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewRoomEquipments;
        private FontAwesome.Sharp.IconButton iconButtonAddRoom;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Button buttonEditRoom;
        private System.Windows.Forms.Label label1;
    }
}