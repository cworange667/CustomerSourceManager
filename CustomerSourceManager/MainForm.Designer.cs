namespace ClientSourceManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.systemManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfosManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerInfosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HousingInfoManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHousingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createHousingInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemDescriptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemManageToolStripMenuItem,
            this.customerManageToolStripMenuItem,
            this.HousingInfoManageToolStripMenuItem,
            this.systemMaintenanceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(639, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // systemManageToolStripMenuItem
            // 
            this.systemManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManageToolStripMenuItem});
            this.systemManageToolStripMenuItem.Name = "systemManageToolStripMenuItem";
            this.systemManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.systemManageToolStripMenuItem.Text = "系统管理";
            // 
            // userManageToolStripMenuItem
            // 
            this.userManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUserInfosToolStripMenuItem,
            this.createUserInfosToolStripMenuItem});
            this.userManageToolStripMenuItem.Name = "userManageToolStripMenuItem";
            this.userManageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userManageToolStripMenuItem.Text = "用户管理";
            // 
            // viewUserInfosToolStripMenuItem
            // 
            this.viewUserInfosToolStripMenuItem.Name = "viewUserInfosToolStripMenuItem";
            this.viewUserInfosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewUserInfosToolStripMenuItem.Text = "查看用户信息";
            this.viewUserInfosToolStripMenuItem.Click += new System.EventHandler(this.viewUserInfosToolStripMenuItem_Click);
            // 
            // createUserInfosToolStripMenuItem
            // 
            this.createUserInfosToolStripMenuItem.Name = "createUserInfosToolStripMenuItem";
            this.createUserInfosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createUserInfosToolStripMenuItem.Text = "创建用户信息";
            this.createUserInfosToolStripMenuItem.Click += new System.EventHandler(this.createUserInfosToolStripMenuItem_Click);
            // 
            // customerManageToolStripMenuItem
            // 
            this.customerManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfosManageToolStripMenuItem});
            this.customerManageToolStripMenuItem.Name = "customerManageToolStripMenuItem";
            this.customerManageToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.customerManageToolStripMenuItem.Text = "客户管理";
            // 
            // customerInfosManageToolStripMenuItem
            // 
            this.customerInfosManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerInfosToolStripMenuItem,
            this.viewCustomerInfosToolStripMenuItem});
            this.customerInfosManageToolStripMenuItem.Name = "customerInfosManageToolStripMenuItem";
            this.customerInfosManageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerInfosManageToolStripMenuItem.Text = "客户信息管理";
            // 
            // createCustomerInfosToolStripMenuItem
            // 
            this.createCustomerInfosToolStripMenuItem.Name = "createCustomerInfosToolStripMenuItem";
            this.createCustomerInfosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createCustomerInfosToolStripMenuItem.Text = "创建客户信息";
            this.createCustomerInfosToolStripMenuItem.Click += new System.EventHandler(this.createCustomerInfosToolStripMenuItem_Click);
            // 
            // viewCustomerInfosToolStripMenuItem
            // 
            this.viewCustomerInfosToolStripMenuItem.Name = "viewCustomerInfosToolStripMenuItem";
            this.viewCustomerInfosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewCustomerInfosToolStripMenuItem.Text = "查看客户信息";
            this.viewCustomerInfosToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerInfosToolStripMenuItem_Click);
            // 
            // HousingInfoManageToolStripMenuItem
            // 
            this.HousingInfoManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHousingInfoToolStripMenuItem,
            this.createHousingInfoToolStripMenuItem});
            this.HousingInfoManageToolStripMenuItem.Name = "HousingInfoManageToolStripMenuItem";
            this.HousingInfoManageToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.HousingInfoManageToolStripMenuItem.Text = "房屋信息管理";
            // 
            // viewHousingInfoToolStripMenuItem
            // 
            this.viewHousingInfoToolStripMenuItem.Name = "viewHousingInfoToolStripMenuItem";
            this.viewHousingInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHousingInfoToolStripMenuItem.Text = "查看房屋信息";
            this.viewHousingInfoToolStripMenuItem.Click += new System.EventHandler(this.viewHousingInfoToolStripMenuItem_Click);
            // 
            // createHousingInfoToolStripMenuItem
            // 
            this.createHousingInfoToolStripMenuItem.Name = "createHousingInfoToolStripMenuItem";
            this.createHousingInfoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createHousingInfoToolStripMenuItem.Text = "创建房屋信息";
            this.createHousingInfoToolStripMenuItem.Click += new System.EventHandler(this.createHousingInfoToolStripMenuItem_Click);
            // 
            // systemMaintenanceToolStripMenuItem
            // 
            this.systemMaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBackupToolStripMenuItem});
            this.systemMaintenanceToolStripMenuItem.Name = "systemMaintenanceToolStripMenuItem";
            this.systemMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.systemMaintenanceToolStripMenuItem.Text = "系统维护";
            // 
            // dataBackupToolStripMenuItem
            // 
            this.dataBackupToolStripMenuItem.Name = "dataBackupToolStripMenuItem";
            this.dataBackupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataBackupToolStripMenuItem.Text = "数据备份";
            this.dataBackupToolStripMenuItem.Click += new System.EventHandler(this.dataBackupToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemDescriptionToolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // systemDescriptionToolStripMenuItem1
            // 
            this.systemDescriptionToolStripMenuItem1.Name = "systemDescriptionToolStripMenuItem1";
            this.systemDescriptionToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.systemDescriptionToolStripMenuItem1.Text = "系统说明";
            this.systemDescriptionToolStripMenuItem1.Click += new System.EventHandler(this.systemDescriptionToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "注销登录";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 541);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "信息管理平台";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem systemManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfosManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerInfosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HousingInfoManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHousingInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createHousingInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemDescriptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}