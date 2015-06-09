using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSourceManager
{
    public partial class ViewCustomerInfos : Form
    {
        public ViewCustomerInfos()
        {
            InitializeComponent();

            string xml = Utilities.GetXMLContent("CustomerInfos.xml");
            DataSet dataset = new DataSet();
            dataset.ReadXml(new System.IO.StringReader(xml));
            DataTable table = dataset.Tables[0];
            this.customerInfosGrid.DataSource = table;
            this.customerInfosGrid.Columns[7].Visible = false;
            DataGridViewButtonColumn modify = new DataGridViewButtonColumn();
            modify.UseColumnTextForButtonValue = true;
            modify.Text = "修改";
            this.customerInfosGrid.Columns.Add(modify);
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.UseColumnTextForButtonValue = true;
            delete.Text = "删除";
            this.customerInfosGrid.Columns.Add(delete);
            this.customerInfosGrid.AllowUserToAddRows = false;
            this.customerInfosGrid.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn dgvc in this.customerInfosGrid.Columns)
                dgvc.ReadOnly = true;
        }
        private void customerInfosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Utilities.DelXml("CustomerInfos.xml", e.RowIndex);
                string xml = Utilities.GetXMLContent("CustomerInfos.xml");
                DataSet dataset = new DataSet();
                dataset.ReadXml(new System.IO.StringReader(xml));
                DataTable table = dataset.Tables[0];
                this.customerInfosGrid.DataSource = table;
            }
            if (e.ColumnIndex == 0)
            {
                string[] userInfoValues = new string[11];
                for (int i = 2; i < 13; i++)
                {
                    userInfoValues[i - 2] = this.customerInfosGrid[i, e.RowIndex].Value.ToString();
                }
                CreateCustomerInfos cui = new CreateCustomerInfos(e.RowIndex, userInfoValues);
                cui.updateGrid = () =>
                {
                    string xml = Utilities.GetXMLContent("CustomerInfos.xml");
                    DataSet dataset = new DataSet();
                    dataset.ReadXml(new System.IO.StringReader(xml));
                    DataTable table = dataset.Tables[0];
                    this.customerInfosGrid.DataSource = table;
                };
                cui.Show();
            }
        }
    }
}
