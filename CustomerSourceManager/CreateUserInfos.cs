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
    public partial class CreateUserInfos : Form
    {
        private int userInfoIndex;
        public delegate void UpdateGrid();
        public UpdateGrid updateGrid;

        public CreateUserInfos(int index = -1, string[] userInfos = null)
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
                textBox8.Enabled = false;
                label8.Enabled = false;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string[] str1 = { "用户编码", "用户名", "用户全名", "职务头衔", "移动电话", "办公电话", "邮件地址" ,"密码"};
            string[] str2 = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text };
            if (userInfoIndex < 0)
                Utilities.AddXml("UserInfos.xml", str1, str2);
            else
            {
                Utilities.ModifyXml("UserInfos.xml", userInfoIndex, str1, str2);
                updateGrid();
            }
            this.Close();
        }
    }
}
