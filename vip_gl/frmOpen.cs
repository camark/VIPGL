using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace vip_gl
{
    public partial class frmOpen : Form
    {


        private const int SC_CLOSE = 0xF060;

        private const int MF_ENABLED = 0x00000000;

        private const int MF_GRAYED = 0x00000001;

        private const int MF_DISABLED = 0x00000002;



        [DllImport("user32.dll", EntryPoint = "GetSystemMenu")]

        private static extern IntPtr GetSystemMenu(IntPtr hWnd, int bRevert);

        [DllImport("User32.dll")]

        public static extern bool EnableMenuItem(IntPtr hMenu, int uIDEnableItem, int uEnable);

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
                return cp;
            }

        }




        public string userid = "";
        public frmOpen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(this.textBox2.Text.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            string str = BitConverter.ToString(md5.ComputeHash(result)).Replace("-", "");
            string str2 = "";
            str2 = new DB().getopwd(this.userid);
            if (str == str2)
            {
                Process.Start("pcii.exe");
                base.Close();
            }
            else
            {
                MessageBox.Show("开箱密码错误！", "系统提示");
                this.textBox2.Text = "";
                this.textBox2.Focus();
            }
        }

        private void frmOpen_Load(object sender, EventArgs e)
        {
            this.textBox2.Focus();

            IntPtr hMenu = GetSystemMenu(this.Handle, 0);
            EnableMenuItem(hMenu, SC_CLOSE, MF_DISABLED | MF_GRAYED);

        }
    }
}
