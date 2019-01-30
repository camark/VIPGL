using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace vip_gl
{
    public partial class frmMain : Form
    {
        public string realname = "";
        public string userid = "";
        public frmMain()
        {
            InitializeComponent();
        }

        public void Backup(string srcPath, string aimPath)
        {
            if (!File.Exists(srcPath))
            {
                throw new Exception("源数据库不存在,无法备份");
            }
            try
            {
                File.Copy(srcPath, aimPath, true);
            }
            catch (IOException iXP)
            {
                throw new Exception(iXP.ToString());
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLbl1.Text = "操作员：" + this.realname;
            OleDbDataReader dr = new DB().getDr2("1");
            if (dr.Read())
            {
                this.Text = dr["title"].ToString() + "--会员积分管理系统";
                this.toolStripStatusLabel1.Text = dr["title"].ToString() + "--会员积分管理系统";
            }
            dr.Close();
        }

        public string ProcessTime()
        {
            int iHour = DateTime.Now.Hour;
            int iMin = DateTime.Now.Minute;
            int iSec = DateTime.Now.Second;
            string sTime = (iHour < 10) ? ("0" + iHour.ToString()) : iHour.ToString();
            return ((sTime + ":" + ((iMin < 10) ? ("0" + iMin.ToString()) : iMin.ToString())) + ":" + ((iSec < 10) ? ("0" + iSec.ToString()) : iSec.ToString()));
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sender == this.timer1)
            {
                this.toolStripStatusTime.Text = "当前时间：" + this.ProcessTime();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您真的要退出程序吗？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出吗", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要退出吗", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void 发卡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdd().Show();
        }

        private void 积分规则ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmJsdo().Show();
        }

        private void 结转日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJfdellist frm = new frmJfdellist();
            frm.Show();
        }

        private void 基本系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBset frm = new frmBset();
            frm.Show();
        }

        private void 数据库备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dt = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "HMM" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            string starPath = Application.StartupPath + @"\vip.mdb";
            string endPath = Application.StartupPath + @"\bak\" + dt + ".mdb";
            this.Backup(starPath, endPath);
            MessageBox.Show("数据库备份成功！\n文件名为：" + dt, "系统提示");
        }

        private void 开钱箱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpen frm = new frmOpen();
            frm.userid = this.userid;
            frm.ShowDialog();
        }

        private void 修改钱箱密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatepwd2 frm = new frmUpdatepwd2();
            frm.userid = this.userid;
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMoneyin frm = new frmMoneyin();
            frm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmJslist frm = new frmJslist();
            frm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmUpdatepwd frm = new frmUpdatepwd();
            frm.userid = this.userid;
            frm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmOpen frm = new frmOpen();
            frm.userid = this.userid;
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtRealName.Text = "";
            this.txtMobile.Text = "";
            this.txtID.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchUser frm = new frmSearchUser();
            frm.id = this.txtID.Text.Trim();
            frm.mobile = this.txtMobile.Text.Trim();
            frm.realname = this.txtRealName.Text.Trim();
            frm.Show();
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
