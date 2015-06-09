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
    public partial class CreateCustomerInfos : Form
    {
        private int userInfoIndex;
        public delegate void UpdateGrid();
        public UpdateGrid updateGrid;

        public CreateCustomerInfos(int index = -1, string[] userInfos = null)
        {
            InitializeComponent();
            userInfoIndex = index;
            if (userInfos != null)
            {
                textBox1.Text = userInfos[0];
                textBox2.Text = userInfos[1];
                textBox3.Text = userInfos[2];
                textBox4.Text = userInfos[3];
                textBox5.Text = userInfos[4];
                textBox6.Text = userInfos[5];
                textBox7.Text = userInfos[6];
                textBox8.Text = userInfos[7];
                textBox9.Text = userInfos[8];
                textBox10.Text = userInfos[9];
                textBox11.Text = userInfos[10];
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string[] str1 = { "客户编码", "客户姓名", "客户性别","客户邮箱", "客户级别", "客户电话", "客户地址", "客户邮编", "客户行业", "客户来源", "客户备注" };
            string[] str2 = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text };
            if (userInfoIndex < 0)
                Utilities.AddXml("CustomerInfos.xml", str1, str2);
            else
            {
                Utilities.ModifyXml("CustomerInfos.xml", userInfoIndex, str1, str2);
                updateGrid();
            }
            this.Close();
        }
    }
}
