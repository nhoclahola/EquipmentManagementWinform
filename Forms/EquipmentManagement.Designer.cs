﻿namespace EquipmentManagementWinform.Forms
{
    partial class EquipmentManagement
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
            this.pictureBoxEquipment = new System.Windows.Forms.PictureBox();
            this.dataGridViewEquipment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.labelEquipmentName = new System.Windows.Forms.Label();
            this.labelTotalQuantity = new System.Windows.Forms.Label();
            this.labelRemainQuantity = new System.Windows.Forms.Label();
            this.textBoxEquipmentName = new System.Windows.Forms.TextBox();
            this.textBoxTotalQuantity = new System.Windows.Forms.TextBox();
            this.textBoxRemainQuantity = new System.Windows.Forms.TextBox();
            this.labelRooms1 = new System.Windows.Forms.Label();
            this.labelRooms2 = new System.Windows.Forms.Label();
            this.iconButtonAddEquipment = new FontAwesome.Sharp.IconButton();
            this.labelTotalPageNumber = new System.Windows.Forms.Label();
            this.labelSlash = new System.Windows.Forms.Label();
            this.iconButtonNextPage = new FontAwesome.Sharp.IconButton();
            this.iconButtonPreviousPage = new FontAwesome.Sharp.IconButton();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.buttonAddEquipmentToRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEquipment
            // 
            this.pictureBoxEquipment.Location = new System.Drawing.Point(653, 36);
            this.pictureBoxEquipment.Name = "pictureBoxEquipment";
            this.pictureBoxEquipment.Size = new System.Drawing.Size(242, 155);
            this.pictureBoxEquipment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEquipment.TabIndex = 0;
            this.pictureBoxEquipment.TabStop = false;
            // 
            // dataGridViewEquipment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewEquipment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEquipment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEquipment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEquipment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEquipment.Location = new System.Drawing.Point(23, 93);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.RowHeadersVisible = false;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(513, 250);
            this.dataGridViewEquipment.TabIndex = 2;
            this.dataGridViewEquipment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEquipment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewEquipment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEquipment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewEquipment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewEquipment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEquipment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEquipment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewEquipment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewEquipment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEquipment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewEquipment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEquipment.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridViewEquipment.ThemeStyle.ReadOnly = false;
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewEquipment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // labelEquipmentName
            // 
            this.labelEquipmentName.AutoSize = true;
            this.labelEquipmentName.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipmentName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEquipmentName.Location = new System.Drawing.Point(591, 225);
            this.labelEquipmentName.Name = "labelEquipmentName";
            this.labelEquipmentName.Size = new System.Drawing.Size(87, 15);
            this.labelEquipmentName.TabIndex = 11;
            this.labelEquipmentName.Text = "Tên thiết bị: ";
            // 
            // labelTotalQuantity
            // 
            this.labelTotalQuantity.AutoSize = true;
            this.labelTotalQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalQuantity.Location = new System.Drawing.Point(591, 260);
            this.labelTotalQuantity.Name = "labelTotalQuantity";
            this.labelTotalQuantity.Size = new System.Drawing.Size(157, 15);
            this.labelTotalQuantity.TabIndex = 12;
            this.labelTotalQuantity.Text = "Tổng số lượng hiện có: ";
            // 
            // labelRemainQuantity
            // 
            this.labelRemainQuantity.AutoSize = true;
            this.labelRemainQuantity.BackColor = System.Drawing.Color.Transparent;
            this.labelRemainQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainQuantity.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRemainQuantity.Location = new System.Drawing.Point(591, 294);
            this.labelRemainQuantity.Name = "labelRemainQuantity";
            this.labelRemainQuantity.Size = new System.Drawing.Size(115, 15);
            this.labelRemainQuantity.TabIndex = 13;
            this.labelRemainQuantity.Text = "Số lượng còn lại:";
            // 
            // textBoxEquipmentName
            // 
            this.textBoxEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEquipmentName.Location = new System.Drawing.Point(768, 222);
            this.textBoxEquipmentName.Name = "textBoxEquipmentName";
            this.textBoxEquipmentName.Size = new System.Drawing.Size(177, 21);
            this.textBoxEquipmentName.TabIndex = 15;
            // 
            // textBoxTotalQuantity
            // 
            this.textBoxTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalQuantity.Location = new System.Drawing.Point(768, 257);
            this.textBoxTotalQuantity.Name = "textBoxTotalQuantity";
            this.textBoxTotalQuantity.ReadOnly = true;
            this.textBoxTotalQuantity.Size = new System.Drawing.Size(33, 21);
            this.textBoxTotalQuantity.TabIndex = 16;
            // 
            // textBoxRemainQuantity
            // 
            this.textBoxRemainQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRemainQuantity.Location = new System.Drawing.Point(768, 294);
            this.textBoxRemainQuantity.Name = "textBoxRemainQuantity";
            this.textBoxRemainQuantity.ReadOnly = true;
            this.textBoxRemainQuantity.Size = new System.Drawing.Size(33, 21);
            this.textBoxRemainQuantity.TabIndex = 17;
            // 
            // labelRooms1
            // 
            this.labelRooms1.AutoSize = true;
            this.labelRooms1.BackColor = System.Drawing.Color.Transparent;
            this.labelRooms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRooms1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRooms1.Location = new System.Drawing.Point(591, 328);
            this.labelRooms1.Name = "labelRooms1";
            this.labelRooms1.Size = new System.Drawing.Size(118, 15);
            this.labelRooms1.TabIndex = 18;
            this.labelRooms1.Text = "Có tại các phòng:";
            // 
            // labelRooms2
            // 
            this.labelRooms2.AutoSize = true;
            this.labelRooms2.BackColor = System.Drawing.Color.Transparent;
            this.labelRooms2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRooms2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRooms2.Location = new System.Drawing.Point(765, 328);
            this.labelRooms2.Name = "labelRooms2";
            this.labelRooms2.Size = new System.Drawing.Size(16, 15);
            this.labelRooms2.TabIndex = 19;
            this.labelRooms2.Text = "\" ";
            // 
            // iconButtonAddEquipment
            // 
            this.iconButtonAddEquipment.FlatAppearance.BorderSize = 0;
            this.iconButtonAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddEquipment.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddEquipment.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconButtonAddEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddEquipment.Location = new System.Drawing.Point(461, 21);
            this.iconButtonAddEquipment.Name = "iconButtonAddEquipment";
            this.iconButtonAddEquipment.Size = new System.Drawing.Size(75, 66);
            this.iconButtonAddEquipment.TabIndex = 20;
            this.iconButtonAddEquipment.UseVisualStyleBackColor = true;
            this.iconButtonAddEquipment.Click += new System.EventHandler(this.iconButtonAddEquipment_Click);
            // 
            // labelTotalPageNumber
            // 
            this.labelTotalPageNumber.AutoSize = true;
            this.labelTotalPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalPageNumber.Location = new System.Drawing.Point(280, 375);
            this.labelTotalPageNumber.Name = "labelTotalPageNumber";
            this.labelTotalPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelTotalPageNumber.TabIndex = 38;
            this.labelTotalPageNumber.Text = "1";
            // 
            // labelSlash
            // 
            this.labelSlash.AutoSize = true;
            this.labelSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlash.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSlash.Location = new System.Drawing.Point(261, 375);
            this.labelSlash.Name = "labelSlash";
            this.labelSlash.Size = new System.Drawing.Size(13, 17);
            this.labelSlash.TabIndex = 37;
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
            this.iconButtonNextPage.Location = new System.Drawing.Point(326, 365);
            this.iconButtonNextPage.Name = "iconButtonNextPage";
            this.iconButtonNextPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonNextPage.TabIndex = 36;
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
            this.iconButtonPreviousPage.Location = new System.Drawing.Point(171, 365);
            this.iconButtonPreviousPage.Name = "iconButtonPreviousPage";
            this.iconButtonPreviousPage.Size = new System.Drawing.Size(43, 37);
            this.iconButtonPreviousPage.TabIndex = 35;
            this.iconButtonPreviousPage.UseVisualStyleBackColor = true;
            this.iconButtonPreviousPage.Click += new System.EventHandler(this.iconButtonPreviousPage_Click);
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPageNumber.Location = new System.Drawing.Point(238, 375);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(17, 17);
            this.labelPageNumber.TabIndex = 34;
            this.labelPageNumber.Text = "1";
            // 
            // buttonAddEquipmentToRoom
            // 
            this.buttonAddEquipmentToRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEquipmentToRoom.Location = new System.Drawing.Point(594, 365);
            this.buttonAddEquipmentToRoom.Name = "buttonAddEquipmentToRoom";
            this.buttonAddEquipmentToRoom.Size = new System.Drawing.Size(154, 58);
            this.buttonAddEquipmentToRoom.TabIndex = 39;
            this.buttonAddEquipmentToRoom.Text = "Thêm thiết bị này vào phòng";
            this.buttonAddEquipmentToRoom.UseVisualStyleBackColor = true;
            this.buttonAddEquipmentToRoom.Visible = false;
            this.buttonAddEquipmentToRoom.Click += new System.EventHandler(this.buttonAddEquipmentToRoom_Click);
            // 
            // EquipmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.buttonAddEquipmentToRoom);
            this.Controls.Add(this.labelTotalPageNumber);
            this.Controls.Add(this.labelSlash);
            this.Controls.Add(this.iconButtonNextPage);
            this.Controls.Add(this.iconButtonPreviousPage);
            this.Controls.Add(this.labelPageNumber);
            this.Controls.Add(this.iconButtonAddEquipment);
            this.Controls.Add(this.labelRooms2);
            this.Controls.Add(this.labelRooms1);
            this.Controls.Add(this.textBoxRemainQuantity);
            this.Controls.Add(this.textBoxTotalQuantity);
            this.Controls.Add(this.textBoxEquipmentName);
            this.Controls.Add(this.labelRemainQuantity);
            this.Controls.Add(this.labelTotalQuantity);
            this.Controls.Add(this.labelEquipmentName);
            this.Controls.Add(this.dataGridViewEquipment);
            this.Controls.Add(this.pictureBoxEquipment);
            this.Name = "EquipmentManagement";
            this.Text = "Quản lý thiết bị";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEquipment;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewEquipment;
        private System.Windows.Forms.Label labelEquipmentName;
        private System.Windows.Forms.Label labelTotalQuantity;
        private System.Windows.Forms.Label labelRemainQuantity;
        private System.Windows.Forms.TextBox textBoxEquipmentName;
        private System.Windows.Forms.TextBox textBoxTotalQuantity;
        private System.Windows.Forms.TextBox textBoxRemainQuantity;
        private System.Windows.Forms.Label labelRooms1;
        private System.Windows.Forms.Label labelRooms2;
        private FontAwesome.Sharp.IconButton iconButtonAddEquipment;
        private System.Windows.Forms.Label labelSlash;
        private FontAwesome.Sharp.IconButton iconButtonNextPage;
        private FontAwesome.Sharp.IconButton iconButtonPreviousPage;
        public System.Windows.Forms.Label labelPageNumber;
        public System.Windows.Forms.Label labelTotalPageNumber;
        private System.Windows.Forms.Button buttonAddEquipmentToRoom;
    }
}