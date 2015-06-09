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
    public partial class CreateHousingInfos : Form
    {
        private int housingInfoIndex;
        public delegate void UpdateGrid();
        public UpdateGrid updateGrid;

        public CreateHousingInfos(int index = -1, string[] housingInfos = null)
        {
            InitializeComponent();
            housingInfoIndex = index;
            if (housingInfos != null)
            {
                textBox1.Text = housingInfos[0];
                textBox2.Text = housingInfos[1];
                textBox3.Text = housingInfos[2];
                textBox4.Text = housingInfos[3];
                textBox5.Text = housingInfos[4];
                textBox6.Text = housingInfos[5];
                textBox7.Text = housingInfos[6];
                textBox8.Text = housingInfos[7];
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string[] str1 = { "编号", "户型", "门牌号", "上架时间", "计量单位", "单位", "是否已售", "户主名称"};
            string[] str2 = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text};
            if (housingInfoIndex < 0)
                Utilities.AddXml("HousingInfos.xml", str1, str2);
            else
            {
                Utilities.ModifyXml("HousingInfos.xml", housingInfoIndex, str1, str2);
                updateGrid();
            }
            this.Close();
        }
    }
}
