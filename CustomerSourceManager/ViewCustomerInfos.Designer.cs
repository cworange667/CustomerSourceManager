namespace ClientSourceManager
{
    partial class ViewCustomerInfos
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
            this.customerInfosGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfosGrid
            // 
            this.customerInfosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerInfosGrid.Location = new System.Drawing.Point(12, 12);
            this.customerInfosGrid.Name = "customerInfosGrid";
            this.customerInfosGrid.RowTemplate.Height = 23;
            this.customerInfosGrid.Size = new System.Drawing.Size(1333, 512);
            this.customerInfosGrid.TabIndex = 1;
            this.customerInfosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerInfosGrid_CellContentClick);
            // 
            // ViewCustomerInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 536);
            this.Controls.Add(this.customerInfosGrid);
            this.Name = "ViewCustomerInfos";
            this.Text = "查看客户信息";
            ((System.ComponentModel.ISupportInitialize)(this.customerInfosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerInfosGrid;
    }
}