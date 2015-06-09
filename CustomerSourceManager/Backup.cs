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
   
    public partial class Backup : Form
    {
        FolderBrowserDialog path;
        public Backup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            path = new FolderBrowserDialog();
            path.ShowDialog();
            this.textBox1.Text = path.SelectedPath;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string location = typeof(Utilities).Assembly.Location;
            string xmlPath = location.Substring(0, location.IndexOf("bin"));

            String sourcePath = xmlPath + "UserInfos.xml";
            String targetPath = path.SelectedPath + "\\UserInfos.xml";
            bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);

            sourcePath = xmlPath + "HousingInfos.xml";
            targetPath = path.SelectedPath + "\\HousingInfos.xml";
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);

            sourcePath = xmlPath + "CustomerInfos.xml";
            targetPath = path.SelectedPath + "\\CustomerInfos.xml";
            System.IO.File.Copy(sourcePath, targetPath, isrewrite);

            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
