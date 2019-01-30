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
    public partial class frmJslist : Form
    {
        public string id = "";
        private string mobile = "";
        private string realname = "";
        
        public frmJslist()
        {
            InitializeComponent();
        }

        private void frmJslist_Load(object sender, EventArgs e)
        {
            this.BindLv();
        }


        public void BindLv()
        {
            this.lbljs.Text = new DB().getonejs(this.id, this.realname, this.mobile).ToString();
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
            this.lv.Columns.Add("加入会员日期", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("积分", 50, HorizontalAlignment.Left);
            this.lv.Columns.Add("消费金额", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("消费时间", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("备注", 500, HorizontalAlignment.Left);
            this.lv.Visible = true;
            OleDbDataReader reader = new DB().getDr4(this.id, this.realname, this.mobile);
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
                li.SubItems.Add(reader["a_adddate"].ToString());
                li.SubItems.Add(reader["js_one"].ToString());
                li.SubItems.Add(reader["in_money"].ToString());
                li.SubItems.Add(reader["adddate"].ToString());
                li.SubItems.Add(reader["bz"].ToString());
                this.lv.Items.Add(li);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.id = this.txtID.Text.Trim();
            this.realname = this.txtRealName.Text.Trim();
            this.mobile = this.txtMobile.Text.Trim();
            this.lv.Clear();
            this.BindLv();
            this.txtID.Text = "";
            this.txtRealName.Text = "";
            this.txtMobile.Text = "";
            this.txtID.Focus();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar != '.') && (e.KeyChar != '\b')) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtRealName_KeyDown(object sender, KeyEventArgs e)
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

    }
}
