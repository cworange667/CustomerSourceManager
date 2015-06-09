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
    public partial class MainForm : Form
    {
        ViewUserInfos viewUserInfos;
        CreateUserInfos createUserInfos;
        ViewCustomerInfos viewCustomerInfos;
        CreateCustomerInfos createCustomerInfos;
        ViewHousingInfos viewHousingInfos;
        CreateHousingInfos createHousingInfos;
        SystemDescription systemDescription;
        Backup backup;
        public MainForm()
        {
            InitializeComponent();
        }

        private void viewUserInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                viewUserInfos = new ViewUserInfos();
                viewUserInfos.Show();
        }

        private void createUserInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
                createUserInfos = new CreateUserInfos();
                createUserInfos.Show();
        }

        private void viewCustomerInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewCustomerInfos = new ViewCustomerInfos();
            viewCustomerInfos.Show();
        }

        private void createCustomerInfosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createCustomerInfos = new CreateCustomerInfos();
            createCustomerInfos.Show();
        }

        private void viewHousingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewHousingInfos = new ViewHousingInfos();
            viewHousingInfos.Show();
        }

        private void createHousingInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createHousingInfos = new CreateHousingInfos();
            createHousingInfos.Show();
        }

        private void systemDescriptionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            systemDescription = new SystemDescription();
            systemDescription.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dataBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backup = new Backup();
            backup.Show();
        }

    }
}
