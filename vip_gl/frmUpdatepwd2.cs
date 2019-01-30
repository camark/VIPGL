using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace vip_gl
{
    public partial class frmUpdatepwd2 : Form
    {
        public string userid = "";
        public frmUpdatepwd2()
        {
            InitializeComponent();
        }

        private void frmUpdatepwd2_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = this.userid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.textBox4.Text.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            string str = BitConverter.ToString(md5.ComputeHash(result)).Replace("-", "");
            byte[] result2 = Encoding.Default.GetBytes(this.textBox2.Text.Trim());
            MD5 md52 = new MD5CryptoServiceProvider();
            string str2 = BitConverter.ToString(md52.ComputeHash(result2)).Replace("-", "");
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("请输入旧密码！", "系统提示");
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("请输入新密码！", "系统提示");
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("请再次输入新密码！", "系统提示");
                this.textBox4.Focus();
            }
            else if (this.textBox3.Text.Trim() != this.textBox4.Text.Trim())
            {
                MessageBox.Show("请重新输入确认新密码！", "系统提示");
                this.textBox4.Text = "";
                this.textBox4.Focus();
            }
            else if (new DB("select * from opwd where userid='" + this.textBox1.Text.Trim() + "' and opwd='" + str2 + "'").login())
            {
                if (new DB().editpwd2(this.userid, str))
                {
                    MessageBox.Show("密码修改成功，下次请使用新密码！", "系统提示");
                }
                else
                {
                    MessageBox.Show("密码修改失败！", "系统提示");
                }
            }
            else
            {
                MessageBox.Show("旧密码错误，密码修改失败！", "系统提示");
                this.textBox2.Text = "";
                this.textBox2.Focus();
            }
        }
    }
}
