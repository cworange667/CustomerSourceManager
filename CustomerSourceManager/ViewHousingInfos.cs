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
    public partial class ViewHousingInfos : Form
    {
        public ViewHousingInfos()
        {
            InitializeComponent();

            string xml = Utilities.GetXMLContent("HousingInfos.xml");
            DataSet dataset = new DataSet();
            dataset.ReadXml(new System.IO.StringReader(xml));
            DataTable table = dataset.Tables[0];
            this.housingInfosGrid.DataSource = table;
            DataGridViewButtonColumn modify = new DataGridViewButtonColumn();
            modify.UseColumnTextForButtonValue = true;
            modify.Text = "修改";
            this.housingInfosGrid.Columns.Add(modify);
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.UseColumnTextForButtonValue = true;
            delete.Text = "删除";
            this.housingInfosGrid.Columns.Add(delete);
            this.housingInfosGrid.AllowUserToAddRows = false;
            this.housingInfosGrid.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn dgvc in this.housingInfosGrid.Columns)
                dgvc.ReadOnly = true;
        }

        private void housingInfosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Utilities.DelXml("HousingInfos.xml", e.RowIndex);
                string xml = Utilities.GetXMLContent("HousingInfos.xml");
                DataSet dataset = new DataSet();
                dataset.ReadXml(new System.IO.StringReader(xml));
                DataTable table = dataset.Tables[0];
                this.housingInfosGrid.DataSource = table;
            }
            if (e.ColumnIndex == 0)
            {
                string[] housingInfoValues = new string[8];
                for (int i = 2; i < 10; i++)
                {
                    housingInfoValues[i - 2] = this.housingInfosGrid[i, e.RowIndex].Value.ToString();
                }
                CreateHousingInfos cui = new CreateHousingInfos(e.RowIndex, housingInfoValues);
                cui.updateGrid = () =>
                {
                    string xml = Utilities.GetXMLContent("HousingInfos.xml");
                    DataSet dataset = new DataSet();
                    dataset.ReadXml(new System.IO.StringReader(xml));
                    DataTable table = dataset.Tables[0];
                    this.housingInfosGrid.DataSource = table;
                };
                cui.Show();
            }
        }
    }
}
