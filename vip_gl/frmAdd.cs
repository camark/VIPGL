using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vip_gl
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text.Trim();
            string mem_name = this.txtRealname.Text.Trim();
            string sex = this.txtSex.SelectedItem.ToString();
            string sfz = this.txtSfz.Text.Trim();
            string mobile = this.txtMobile.Text.Trim();
            string tel = this.txtTel.Text.Trim();
            string birthday = this.txtbirthday.Text.Trim();
            string addr = this.txtAddr.Text.Trim();
            string com = this.txtCom.Text.Trim();
            if (!new DB().checkidsingle(id))
            {
                if (new DB().addmember(id, mem_name, sex, sfz, mobile, tel, birthday, addr, com))
                {
                    MessageBox.Show("会员添加成功！", "系统提示");
                    this.txtID.Text = "";
                    this.txtRealname.Text = "";
                    this.txtSfz.Text = "";
                    this.txtMobile.Text = "";
                    this.txtTel.Text = "";
                    this.txtbirthday.Text = "";
                    this.txtAddr.Text = "";
                    this.txtCom.Text = "";
                    this.txtID.Focus();
                }
            }
            else
            {
                MessageBox.Show("会员ID不能重复！", "系统提示");
                this.txtID.Text = "";
                this.txtID.Focus();
            }
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.txtSex.SelectedIndex = 1;
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRealname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtbirthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSfz_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtAddr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtCom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
