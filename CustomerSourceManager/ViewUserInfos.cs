using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ClientSourceManager
{
    public partial class ViewUserInfos : Form
    {
        public ViewUserInfos()
        {
            InitializeComponent();

            string xml = Utilities.GetXMLContent("UserInfos.xml");
            DataSet dataset = new DataSet();
            dataset.ReadXml(new System.IO.StringReader(xml));
            DataTable table = dataset.Tables[0];
            this.userInfosGrid.DataSource = table;
            DataGridViewButtonColumn modify = new DataGridViewButtonColumn();
            modify.UseColumnTextForButtonValue = true;
            modify.Text = "修改";
            this.userInfosGrid.Columns.Add(modify);
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
            delete.UseColumnTextForButtonValue = true;
            delete.Text = "删除";
            this.userInfosGrid.Columns.Add(delete);
            this.userInfosGrid.AllowUserToAddRows = false;
            this.userInfosGrid.AllowUserToResizeRows = false;
            foreach (DataGridViewColumn dgvc in this.userInfosGrid.Columns)
                dgvc.ReadOnly = true;
            
        }

        private void userInfosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Utilities.DelXml("UserInfos.xml", e.RowIndex);
                string xml = Utilities.GetXMLContent("UserInfos.xml");
                DataSet dataset = new DataSet();
                dataset.ReadXml(new System.IO.StringReader(xml));
                DataTable table = dataset.Tables[0];
                this.userInfosGrid.DataSource = table;
            }
            if (e.ColumnIndex == 0)
            {
                string[] userInfoValues = new string[7];
                for (int i = 2; i < 9; i++)
                {
                    userInfoValues[i-2] = this.userInfosGrid[i, e.RowIndex].Value.ToString();
                }
                CreateUserInfos cui = new CreateUserInfos(e.RowIndex, userInfoValues);
                cui.updateGrid = () =>
                {
                    string xml = Utilities.GetXMLContent("UserInfos.xml");
                    DataSet dataset = new DataSet();
                    dataset.ReadXml(new System.IO.StringReader(xml));
                    DataTable table = dataset.Tables[0];
                    this.userInfosGrid.DataSource = table;
                };
                cui.Show();
            }
        }


    }
}
