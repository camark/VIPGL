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
    public partial class frmSearchUser : Form
    {
        public string id = "";
        public string mobile = "";
        public string realname = "";

        private int i;


        public frmSearchUser()
        {
            InitializeComponent();
        }

       
        private void frmSearchUser_Load(object sender, EventArgs e)
        {
            this.BindLv();
            this.label5.Text = this.i.ToString();
        }


        public void BindLv()
        {
            OleDbDataReader dr1 = new DB().getDr2("1");
            int todate1 = 0;
            if (dr1.Read())
            {
                todate1 = Convert.ToInt32(dr1["todate"]);
            }
            dr1.Close();
            this.lv.GridLines = true;
            this.lv.FullRowSelect = true;
            this.lv.View = View.Details;
            this.lv.Scrollable = true;
            this.lv.MultiSelect = false;
            this.lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lv.Columns.Add("卡号", 120, HorizontalAlignment.Left);
            this.lv.Columns.Add("姓名", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("积分", 60, HorizontalAlignment.Left);
            this.lv.Columns.Add("身份证", 200, HorizontalAlignment.Left);
            this.lv.Columns.Add("手机号码", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("固定电话", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("生日", 100, HorizontalAlignment.Left);
            this.lv.Columns.Add("联系地址", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("单位名称", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("加入会员日期", 150, HorizontalAlignment.Left);
            this.lv.Columns.Add("状态", 60, HorizontalAlignment.Left);
            this.lv.Visible = true;
            OleDbDataReader reader = new DB().getDr(this.id, this.realname, this.mobile);
            while (reader.Read())
            {
                this.i++;
                DateTime dt = Convert.ToDateTime(reader["adddate"]).AddMonths(todate1);
                string str_dt = "";
                if (dt < DateTime.Now)
                {
                    str_dt = "过期";
                }
                else
                {
                    str_dt = "正常";
                }
                string jf = new DB().getonejs(reader["id"].ToString()).ToString();
                ListViewItem li = new ListViewItem();
                li.SubItems.Clear();
                li.SubItems[0].Text = reader["id"].ToString();
                li.SubItems.Add(reader["mem_name"].ToString());
                li.SubItems.Add(jf);
                li.SubItems.Add(reader["sfz"].ToString());
                li.SubItems.Add(reader["mobile"].ToString());
                li.SubItems.Add(reader["tel"].ToString());
                li.SubItems.Add(reader["birthday"].ToString());
                li.SubItems.Add(reader["addr"].ToString());
                li.SubItems.Add(reader["com"].ToString());
                li.SubItems.Add(reader["adddate"].ToString());
                li.SubItems.Add(str_dt);
                this.lv.Items.Add(li);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lv.Clear();
            this.id = this.txtID.Text.Trim();
            this.mobile = this.txtMobile.Text.Trim();
            this.realname = this.txtRealName.Text.Trim();
            this.i = 0;
            this.BindLv();
            this.label5.Text = this.i.ToString();
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

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv.SelectedItems.Count != 0)
            {
                int coun = this.lv.SelectedItems.Count;
                string caption = "此删除操作将删除此会员及其会员积分信息\n是否确定删除：";
                string mid = "";
                for (int i = 0; i < coun; i++)
                {
                    mid = this.lv.SelectedItems[i].Text;
                }
                if (MessageBox.Show((caption + this.lv.Items[this.lv.SelectedIndices[0]].SubItems[1].Text + ".") + "?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool f = false;
                    bool f2 = false;
                    for (int a = 0; a < coun; a++)
                    {
                        string sql = "delete from members where id='" + mid + "'";
                        string sql2 = "delete from integral where member_id='" + mid + "'";
                        f = new DB(sql).deloperator();
                        f2 = new DB(sql2).deloperator();
                    }
                    if (f && f2)
                    {
                        MessageBox.Show("用户信息删除成功！", "提示");
                        this.lv.Clear();
                        this.id = this.txtID.Text.Trim();
                        this.mobile = this.txtMobile.Text.Trim();
                        this.realname = this.txtRealName.Text.Trim();
                        this.i = 0;
                        this.BindLv();
                        this.label4.Text = this.i.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择要删除的用户!", "提示");
            }
        }

        private void 积分结转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv.SelectedItems.Count != 0)
            {
                int coun = this.lv.SelectedItems.Count;
                string mid = "";
                for (int i = 0; i < coun; i++)
                {
                    mid = this.lv.SelectedItems[i].Text;
                }
                if (MessageBox.Show("该客户积分总计为：" + new DB().getonejs(mid).ToString() + "。\n积分结转后以往积分将被清空，请慎重！？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmDeljflog frm = new frmDeljflog();
                    frm.mid = mid;
                    frm.Show();
                }
            }
        }

        private void 积分记录详情ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv.SelectedItems.Count != 0)
            {
                int coun = this.lv.SelectedItems.Count;
                string mid = "";
                for (int i = 0; i < coun; i++)
                {
                    mid = this.lv.SelectedItems[i].Text;
                }
                frmJslist frm = new frmJslist();
                frm.id = mid;
                frm.Show();
            }
        }

        


        private void lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new frmUserInfo(this).Show();
        }

    }
}
