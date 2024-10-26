namespace EquipmentManagementWinform
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.requestButton = new FontAwesome.Sharp.IconButton();
            this.equipButton = new FontAwesome.Sharp.IconButton();
            this.roomButton = new FontAwesome.Sharp.IconButton();
            this.userButton = new FontAwesome.Sharp.IconButton();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.requestButton);
            this.panelMenu.Controls.Add(this.equipButton);
            this.panelMenu.Controls.Add(this.roomButton);
            this.panelMenu.Controls.Add(this.userButton);
            this.panelMenu.Controls.Add(this.searchButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 547);
            this.panelMenu.TabIndex = 0;
            // 
            // requestButton
            // 
            this.requestButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestButton.FlatAppearance.BorderSize = 0;
            this.requestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.requestButton.IconChar = FontAwesome.Sharp.IconChar.AlignLeft;
            this.requestButton.IconColor = System.Drawing.Color.Gainsboro;
            this.requestButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.requestButton.IconSize = 32;
            this.requestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestButton.Location = new System.Drawing.Point(0, 380);
            this.requestButton.Name = "requestButton";
            this.requestButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.requestButton.Size = new System.Drawing.Size(220, 60);
            this.requestButton.TabIndex = 6;
            this.requestButton.Text = "Phiếu đăng ký";
            this.requestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // equipButton
            // 
            this.equipButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.equipButton.FlatAppearance.BorderSize = 0;
            this.equipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equipButton.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.equipButton.IconColor = System.Drawing.Color.Gainsboro;
            this.equipButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.equipButton.IconSize = 32;
            this.equipButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipButton.Location = new System.Drawing.Point(0, 320);
            this.equipButton.Name = "equipButton";
            this.equipButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.equipButton.Size = new System.Drawing.Size(220, 60);
            this.equipButton.TabIndex = 5;
            this.equipButton.Text = "Thiết bị";
            this.equipButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equipButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.equipButton.UseVisualStyleBackColor = true;
            this.equipButton.Click += new System.EventHandler(this.equipButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.roomButton.FlatAppearance.BorderSize = 0;
            this.roomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.roomButton.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.roomButton.IconColor = System.Drawing.Color.Gainsboro;
            this.roomButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.roomButton.IconSize = 32;
            this.roomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomButton.Location = new System.Drawing.Point(0, 260);
            this.roomButton.Name = "roomButton";
            this.roomButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.roomButton.Size = new System.Drawing.Size(220, 60);
            this.roomButton.TabIndex = 4;
            this.roomButton.Text = "Phòng học";
            this.roomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roomButton.UseVisualStyleBackColor = true;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userButton.IconColor = System.Drawing.Color.Gainsboro;
            this.userButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userButton.IconSize = 32;
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.Location = new System.Drawing.Point(0, 200);
            this.userButton.Name = "userButton";
            this.userButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.userButton.Size = new System.Drawing.Size(220, 60);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "Người dùng";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchButton.IconColor = System.Drawing.Color.Gainsboro;
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.IconSize = 32;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(0, 140);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.searchButton.Size = new System.Drawing.Size(220, 60);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Tìm kiếm";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.homeButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.Image = global::EquipmentManagementWinform.Properties.Resources.Logo_Trường_Đại_Học_Sư_Phạm_Kỹ_Thuật_TP_Hồ_Chí_Minh;
            this.homeButton.Location = new System.Drawing.Point(28, 23);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(155, 101);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 0;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleChildForm.Location = new System.Drawing.Point(60, 30);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(68, 25);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(964, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 90);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(964, 457);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 547);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton searchButton;
        private FontAwesome.Sharp.IconButton requestButton;
        private FontAwesome.Sharp.IconButton equipButton;
        private FontAwesome.Sharp.IconButton roomButton;
        private FontAwesome.Sharp.IconButton userButton;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

