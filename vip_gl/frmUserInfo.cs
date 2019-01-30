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
    public partial class frmUserInfo : Form
    {
        private frmSearchUser f1;
        
        public frmUserInfo()
        {
            InitializeComponent();
        }

        public frmUserInfo(frmSearchUser myform)
        {
           InitializeComponent();
            f1 = myform;
        }

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            this.txtID.Text = this.f1.lv.SelectedItems[0].Text;
            OleDbDataReader dr = new DB().getDr(this.txtID.Text.Trim());
            while (dr.Read())
            {
                this.txtRealName.Text = dr["mem_name"].ToString();
                this.txtTel.Text = dr["tel"].ToString();
                this.txtSex.Text = dr["sex"].ToString();
                this.txtSex2.Text = dr["sex"].ToString();
                this.txtMobile.Text = dr["mobile"].ToString();
                this.txtSfz.Text = dr["sfz"].ToString();
                this.txtBirthday.Text = dr["birthday"].ToString();
                this.txtAddr.Text = dr["addr"].ToString();
                this.txtCom.Text = dr["com"].ToString();
                this.txtAdddate.Text = dr["adddate"].ToString();
                this.txtRealName2.Text = dr["mem_name"].ToString();
                this.txtTel2.Text = dr["tel"].ToString();
                this.txtMobile2.Text = dr["mobile"].ToString();
                this.txtSfz2.Text = dr["sfz"].ToString();
                this.txtBirthday2.Text = dr["birthday"].ToString();
                this.txtAddr2.Text = dr["addr"].ToString();
                this.txtCom2.Text = dr["com"].ToString();
                this.txtadddate2.Text = dr["adddate"].ToString();
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text.Trim();
            string mem_name = this.txtRealName2.Text.Trim();
            string sex = this.txtSex2.Text.Trim();
            string sfz = this.txtSfz2.Text.Trim();
            string mobile = this.txtMobile2.Text.Trim();
            string tel = this.txtTel2.Text.Trim();
            string birthday = this.txtBirthday2.Text.Trim();
            string addr = this.txtAddr2.Text.Trim();
            string com = this.txtCom2.Text.Trim();
            DateTime adddate = Convert.ToDateTime(this.txtadddate2.Text.Trim());
            string id2 = this.txtID2.Text.Trim();
            if (id2 != "")
            {
                bool a = new DB().editID(id, id2);
                new DB().editmember(id, mem_name, sex, sfz, mobile, tel, birthday, addr, com, adddate);
                if (a)
                {
                    MessageBox.Show("修改会员信息成功！", "系统提示");
                }
                else
                {
                    MessageBox.Show("修改会员信息失败！", "系统提示");
                }
            }
            else if (new DB().editmember(id, mem_name, sex, sfz, mobile, tel, birthday, addr, com, adddate))
            {
                MessageBox.Show("修改会员信息成功！", "系统提示");
            }
            else
            {
                MessageBox.Show("修改会员信息失败！", "系统提示");
            }
        }
    }
}
