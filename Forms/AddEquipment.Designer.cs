namespace EquipmentManagementWinform.Forms
{
    partial class AddEquipment
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
            this.iconButtonAddEquipment = new FontAwesome.Sharp.IconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxEquipmentName = new System.Windows.Forms.TextBox();
            this.labelEquipmentName = new System.Windows.Forms.Label();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxEquipmentImage = new System.Windows.Forms.PictureBox();
            this.textBoxBrandName = new System.Windows.Forms.TextBox();
            this.labelBrandName = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipmentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonAddEquipment
            // 
            this.iconButtonAddEquipment.FlatAppearance.BorderSize = 0;
            this.iconButtonAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddEquipment.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonAddEquipment.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(118)))), ((int)(((byte)(176)))));
            this.iconButtonAddEquipment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddEquipment.Location = new System.Drawing.Point(12, 12);
            this.iconButtonAddEquipment.Name = "iconButtonAddEquipment";
            this.iconButtonAddEquipment.Size = new System.Drawing.Size(75, 66);
            this.iconButtonAddEquipment.TabIndex = 21;
            this.iconButtonAddEquipment.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Location = new System.Drawing.Point(81, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(146, 24);
            this.labelTitle.TabIndex = 42;
            this.labelTitle.Text = "THÊM THIẾT BỊ";
            // 
            // textBoxEquipmentName
            // 
            this.textBoxEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEquipmentName.Location = new System.Drawing.Point(164, 76);
            this.textBoxEquipmentName.Name = "textBoxEquipmentName";
            this.textBoxEquipmentName.Size = new System.Drawing.Size(177, 21);
            this.textBoxEquipmentName.TabIndex = 44;
            // 
            // labelEquipmentName
            // 
            this.labelEquipmentName.AutoSize = true;
            this.labelEquipmentName.BackColor = System.Drawing.Color.Transparent;
            this.labelEquipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEquipmentName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEquipmentName.Location = new System.Drawing.Point(75, 79);
            this.labelEquipmentName.Name = "labelEquipmentName";
            this.labelEquipmentName.Size = new System.Drawing.Size(83, 15);
            this.labelEquipmentName.TabIndex = 43;
            this.labelEquipmentName.Text = "Tên thiết bị:";
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(67, 236);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectImage.TabIndex = 51;
            this.buttonSelectImage.Text = "Chọn ảnh";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(174, 378);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 35);
            this.buttonAdd.TabIndex = 55;
            this.buttonAdd.Text = "Thêm";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_ClickAsync);
            // 
            // pictureBoxEquipmentImage
            // 
            this.pictureBoxEquipmentImage.Location = new System.Drawing.Point(153, 236);
            this.pictureBoxEquipmentImage.Name = "pictureBoxEquipmentImage";
            this.pictureBoxEquipmentImage.Size = new System.Drawing.Size(177, 125);
            this.pictureBoxEquipmentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEquipmentImage.TabIndex = 47;
            this.pictureBoxEquipmentImage.TabStop = false;
            // 
            // textBoxBrandName
            // 
            this.textBoxBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBrandName.Location = new System.Drawing.Point(164, 112);
            this.textBoxBrandName.Name = "textBoxBrandName";
            this.textBoxBrandName.Size = new System.Drawing.Size(177, 21);
            this.textBoxBrandName.TabIndex = 49;
            // 
            // labelBrandName
            // 
            this.labelBrandName.AutoSize = true;
            this.labelBrandName.BackColor = System.Drawing.Color.Transparent;
            this.labelBrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrandName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBrandName.Location = new System.Drawing.Point(75, 112);
            this.labelBrandName.Name = "labelBrandName";
            this.labelBrandName.Size = new System.Drawing.Size(79, 15);
            this.labelBrandName.TabIndex = 48;
            this.labelBrandName.Text = "Tên hãng:  ";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(164, 151);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(177, 67);
            this.textBoxDescription.TabIndex = 50;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDescription.Location = new System.Drawing.Point(75, 151);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(55, 15);
            this.labelDescription.TabIndex = 50;
            this.labelDescription.Text = "Mô tả:  ";
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxBrandName);
            this.Controls.Add(this.labelBrandName);
            this.Controls.Add(this.pictureBoxEquipmentImage);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSelectImage);
            this.Controls.Add(this.textBoxEquipmentName);
            this.Controls.Add(this.labelEquipmentName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.iconButtonAddEquipment);
            this.Name = "AddEquipment";
            this.Text = "Thêm thiết bị";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquipmentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonAddEquipment;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxEquipmentName;
        private System.Windows.Forms.Label labelEquipmentName;
        private System.Windows.Forms.Button buttonSelectImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxEquipmentImage;
        private System.Windows.Forms.TextBox textBoxBrandName;
        private System.Windows.Forms.Label labelBrandName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
    }
}