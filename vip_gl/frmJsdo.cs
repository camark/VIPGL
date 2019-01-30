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
    public partial class frmJsdo : Form
    {
        public frmJsdo()
        {
            InitializeComponent();
        }

        private void frmJsdo_Load(object sender, EventArgs e)
        {
            OleDbDataReader dr = new DB().getDr2("1");
            if (dr.Read())
            {
                this.textBox1.Text = dr["jfmoneytoint"].ToString();
                this.textBox2.Text = dr["jfinout"].ToString();
                this.textBox3.Text = dr["todate"].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int jfmoneytoint = Convert.ToInt32(this.textBox1.Text.Trim());
            int jfinout = Convert.ToInt32(this.textBox2.Text.Trim());
            int todate = Convert.ToInt32(this.textBox3.Text.Trim());
            if (new DB().editjsg("1", jfmoneytoint, jfinout, todate))
            {
                MessageBox.Show("积分规则修改成功！", "系统提示");
            }
            else
            {
                MessageBox.Show("积分规则修改失败！", "系统提示");
            }
        }
    }
}
