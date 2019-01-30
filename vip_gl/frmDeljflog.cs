using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vip_gl
{
    public partial class frmDeljflog : Form
    {
        public string mid = "";
        public frmDeljflog()
        {
            InitializeComponent();
        }

        private void frmDeljflog_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入结转积分日志", "系统提示");
                this.textBox1.Focus();
            }
            else
            {
                bool Flag = false;
                if (new DB().zeroJf(this.mid))
                {
                    Flag = true;
                }
                if (Flag && new DB().adddellog(this.mid, this.textBox1.Text.Trim()))
                {
                    MessageBox.Show("结转积分成功！", "系统提示");
                    base.Close();
                }
                else
                {
                    MessageBox.Show("结转积分失败！", "系统提示");
                    base.Close();
                }
            }
        }
    }
}
