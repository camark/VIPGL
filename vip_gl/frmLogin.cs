using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vip_gl
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.txtPwd.Text.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            string str = BitConverter.ToString(md5.ComputeHash(result)).Replace("-", "");
            if (this.txtUserName.Text.Length == 0)
            {
                MessageBox.Show("用户名不能为空", "系统提示");
                this.txtUserName.Focus();
            }
            else if (this.txtPwd.Text.Length == 0)
            {
                MessageBox.Show("用户密码不能为空", "系统提示");
                this.txtPwd.Focus();
            }
            else if ((this.txtUserName.Text != "") && (this.txtPwd.Text != ""))
            {
                if (new DB("select * from users where userid='" + this.txtUserName.Text.Trim() + "' and userpwd='" + str + "'").login())
                {
                    base.Hide();
                    frmMain frm = new frmMain();
                    string str_realname = new DB().getrealname(this.txtUserName.Text.Trim());
                    frm.realname = str_realname;
                    frm.userid = this.txtUserName.Text.Trim();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("用户名或者密码，请检查！", "系统提示");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
