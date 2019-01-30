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
    public partial class frmJfdellist : Form
    {
        public frmJfdellist()
        {
            InitializeComponent();
        }

        private void frmJfdellist_Load(object sender, EventArgs e)
        {
            this.BindLv();
        }

        public void BindLv()
        {
            this.lv.GridLines = true;
            this.lv.FullRowSelect = true;
            this.lv.View = View.Details;
            this.lv.Scrollable = true;
            this.lv.MultiSelect = false;
            this.lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lv.Columns.Add("卡号", 120, HorizontalAlignment.Left);
            this.lv.Columns.Add("姓名", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("身份证", 200, HorizontalAlignment.Left);
            this.lv.Columns.Add("手机号码", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("固定电话", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("生日", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("联系地址", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("单位名称", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("结转积分时备注", 500, HorizontalAlignment.Left);
            this.lv.Columns.Add("操作时间", 150, HorizontalAlignment.Left);
            this.lv.Visible = true;
            string id = this.txtID.Text.Trim();
            string realname = this.txtRealName.Text.Trim();
            string mobile = this.txtMobile.Text.Trim();
            OleDbDataReader reader = new DB().getDr5(id, realname, mobile);
            while (reader.Read())
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = reader["id"].ToString();
                li.SubItems.Add(reader["mem_name"].ToString());
                li.SubItems.Add(reader["sfz"].ToString());
                li.SubItems.Add(reader["mobile"].ToString());
                li.SubItems.Add(reader["tel"].ToString());
                li.SubItems.Add(reader["birthday"].ToString());
                li.SubItems.Add(reader["addr"].ToString());
                li.SubItems.Add(reader["com"].ToString());
                li.SubItems.Add(reader["dellog"].ToString());
                li.SubItems.Add(reader["adddate"].ToString());
                this.lv.Items.Add(li);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lv.Clear();
            this.BindLv();
        }

    }
}
