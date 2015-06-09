namespace ClientSourceManager
{
    partial class ViewHousingInfos
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
            this.housingInfosGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.housingInfosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // housingInfosGrid
            // 
            this.housingInfosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.housingInfosGrid.Location = new System.Drawing.Point(12, 12);
            this.housingInfosGrid.Name = "housingInfosGrid";
            this.housingInfosGrid.RowTemplate.Height = 23;
            this.housingInfosGrid.Size = new System.Drawing.Size(1095, 505);
            this.housingInfosGrid.TabIndex = 2;
            this.housingInfosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.housingInfosGrid_CellContentClick);
            // 
            // ViewHousingInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 529);
            this.Controls.Add(this.housingInfosGrid);
            this.Name = "ViewHousingInfos";
            this.Text = "查看住房信息";
            ((System.ComponentModel.ISupportInitialize)(this.housingInfosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView housingInfosGrid;
    }
}