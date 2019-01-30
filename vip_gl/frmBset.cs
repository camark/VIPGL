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
    public partial class frmBset : Form
    {
        public frmBset()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = this.txtTitle.Text.Trim();
            if (new DB().editBset("1", title))
            {
                MessageBox.Show("基本设置配置成功！", "系统提示");
            }
            else
            {
                MessageBox.Show("基本设置配置失败！", "系统提示");
            }
        }

        private void frmBset_Load(object sender, EventArgs e)
        {
            OleDbDataReader dr = new DB().getDr2("1");
            if (dr.Read())
            {
                this.txtTitle.Text = dr["title"].ToString();
            }
            dr.Close();
        }
    }
}
