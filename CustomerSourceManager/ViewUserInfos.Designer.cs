namespace ClientSourceManager
{
    partial class ViewUserInfos
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
            this.components = new System.ComponentModel.Container();
            this.userInfosGrid = new System.Windows.Forms.DataGridView();
            this.xmlUtilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userInfosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlUtilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userInfosGrid
            // 
            this.userInfosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfosGrid.Location = new System.Drawing.Point(12, 12);
            this.userInfosGrid.Name = "userInfosGrid";
            this.userInfosGrid.RowTemplate.Height = 23;
            this.userInfosGrid.Size = new System.Drawing.Size(1008, 511);
            this.userInfosGrid.TabIndex = 0;
            this.userInfosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userInfosGrid_CellContentClick);
            // 
            // xmlUtilBindingSource
            // 
            this.xmlUtilBindingSource.DataSource = typeof(ClientSourceManager.XmlUtil);
            // 
            // ViewUserInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 535);
            this.Controls.Add(this.userInfosGrid);
            this.Name = "ViewUserInfos";
            this.Text = "查看用户信息";
            ((System.ComponentModel.ISupportInitialize)(this.userInfosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlUtilBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource xmlUtilBindingSource;
        private System.Windows.Forms.DataGridView userInfosGrid;


    }
}