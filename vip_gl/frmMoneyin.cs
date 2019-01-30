using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace vip_gl
{
    public partial class frmMoneyin : Form
    {
        public frmMoneyin()
        {
            InitializeComponent();
        }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar != '.') && (e.KeyChar != '\b')) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtMoney.Text = "";
            this.richTextBox1.Text = "";
            this.txtID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            string id = this.txtID.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("卡号不能为空！", "系统提示");
                this.txtID.Focus();
            }
            else
            {
                double money = 0.0;
                if (this.txtMoney.Text.Trim() != "")
                {
                    money = Convert.ToDouble(this.txtMoney.Text.Trim());
                }
                if (!new DB().checkidsingle(id))
                {
                    MessageBox.Show("此卡未在系统注册，请先注册！", "系统提示");
                }
                else
                {
                    double js = 0.0;
                    OleDbDataReader dr = new DB().getDr2("1");
                    if (dr.Read())
                    {
                        if (Convert.ToBoolean(Convert.ToInt32(dr["jfinout"])))
                        {
                            js = money / Convert.ToDouble(dr["jfmoneytoint"]);
                        }
                        else
                        {
                            js = Math.Floor((double)(money / Convert.ToDouble(dr["jfmoneytoint"])));
                        }
                    }
                    string strjs = js.ToString();
                    string bz = this.richTextBox1.Text.Trim();
                    if (new DB().addintegral(id, money, strjs, bz))
                    {
                        MessageBox.Show("会员积分添加成功！", "系统提示");
                        this.txtID.Text = "";
                        this.txtMoney.Text = "";
                        this.richTextBox1.Text = "";
                        this.txtID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("会员积分添加失败！", "系统提示");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text == "")
            {
                MessageBox.Show("请输入卡ID", "系统提示");
                this.txtID.Focus();
            }
            else
            {
                frmJslist frm = new frmJslist();
                frm.id = this.txtID.Text.Trim();
                frm.Show();
            }

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
