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
    public partial class Login : Form
    {
        private string userName;
        private string userPassword;
        private LoginInfos loginInfos;
        private bool successLogin;

        public Login()
        {
            InitializeComponent();
            //loginInfos = Utilities.XMLRead<LoginInfos>("LoginInfos.xml");
            successLogin = false;
        }

        private void conformButton_Click(object sender, EventArgs e)
        {
            userName = userNameText.Text;
            userPassword = userPasswordText.Text;

            if(Utilities.CheckPassword("UserInfos.xml", userName, userPassword))
            {
                MessageBox.Show("登陆成功！");
                successLogin = true;
                this.Close();
            }
            else
                MessageBox.Show("登陆失败！");

            //User u = loginInfos.users.Find(res => res.userName == userName);
            //if (u != null)
            //{
            //    if (u.password == userPassword)
            //    {
            //        MessageBox.Show("登陆成功！");
            //        this.Close();
            //    }
            //    else
            //        MessageBox.Show("密码错误！");
            //}
            //else
            //    MessageBox.Show("该用户不存在！");

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!successLogin)
                Application.Exit();
        }
    }
}
