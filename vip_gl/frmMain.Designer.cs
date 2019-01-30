namespace vip_gl
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.会员卡管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消费结算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.积分规则ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结转日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开钱箱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改钱箱密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl1,
            this.toolStripStatusTime,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl1
            // 
            this.toolStripStatusLbl1.Name = "toolStripStatusLbl1";
            this.toolStripStatusLbl1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLbl1.Text = "toolStripStatusLbl1";
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusTime.Text = "toolStripStatusTime";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会员卡管理ToolStripMenuItem,
            this.消费结算ToolStripMenuItem,
            this.系统管理SToolStripMenuItem,
            this.退出QToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 会员卡管理ToolStripMenuItem
            // 
            this.会员卡管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发卡ToolStripMenuItem});
            this.会员卡管理ToolStripMenuItem.Name = "会员卡管理ToolStripMenuItem";
            this.会员卡管理ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.会员卡管理ToolStripMenuItem.Text = "会员卡管理(&U)";
            // 
            // 发卡ToolStripMenuItem
            // 
            this.发卡ToolStripMenuItem.Name = "发卡ToolStripMenuItem";
            this.发卡ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.发卡ToolStripMenuItem.Text = "发卡";
            this.发卡ToolStripMenuItem.Click += new System.EventHandler(this.发卡ToolStripMenuItem_Click);
            // 
            // 消费结算ToolStripMenuItem
            // 
            this.消费结算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.积分规则ToolStripMenuItem,
            this.结转日志ToolStripMenuItem});
            this.消费结算ToolStripMenuItem.Name = "消费结算ToolStripMenuItem";
            this.消费结算ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.消费结算ToolStripMenuItem.Text = "消费结算(&O)";
            // 
            // 积分规则ToolStripMenuItem
            // 
            this.积分规则ToolStripMenuItem.Name = "积分规则ToolStripMenuItem";
            this.积分规则ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.积分规则ToolStripMenuItem.Text = "积分规则";
            this.积分规则ToolStripMenuItem.Click += new System.EventHandler(this.积分规则ToolStripMenuItem_Click);
            // 
            // 结转日志ToolStripMenuItem
            // 
            this.结转日志ToolStripMenuItem.Name = "结转日志ToolStripMenuItem";
            this.结转日志ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.结转日志ToolStripMenuItem.Text = "结转日志";
            this.结转日志ToolStripMenuItem.Click += new System.EventHandler(this.结转日志ToolStripMenuItem_Click);
            // 
            // 系统管理SToolStripMenuItem
            // 
            this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本系统设置ToolStripMenuItem,
            this.数据库备份ToolStripMenuItem,
            this.开钱箱ToolStripMenuItem,
            this.修改钱箱密码ToolStripMenuItem});
            this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
            this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.系统管理SToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 基本系统设置ToolStripMenuItem
            // 
            this.基本系统设置ToolStripMenuItem.Name = "基本系统设置ToolStripMenuItem";
            this.基本系统设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.基本系统设置ToolStripMenuItem.Text = "基本系统设置";
            this.基本系统设置ToolStripMenuItem.Click += new System.EventHandler(this.基本系统设置ToolStripMenuItem_Click);
            // 
            // 数据库备份ToolStripMenuItem
            // 
            this.数据库备份ToolStripMenuItem.Name = "数据库备份ToolStripMenuItem";
            this.数据库备份ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据库备份ToolStripMenuItem.Text = "数据库备份";
            this.数据库备份ToolStripMenuItem.Click += new System.EventHandler(this.数据库备份ToolStripMenuItem_Click);
            // 
            // 开钱箱ToolStripMenuItem
            // 
            this.开钱箱ToolStripMenuItem.Name = "开钱箱ToolStripMenuItem";
            this.开钱箱ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.开钱箱ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开钱箱ToolStripMenuItem.Text = "开钱箱";
            this.开钱箱ToolStripMenuItem.Click += new System.EventHandler(this.开钱箱ToolStripMenuItem_Click);
            // 
            // 修改钱箱密码ToolStripMenuItem
            // 
            this.修改钱箱密码ToolStripMenuItem.Name = "修改钱箱密码ToolStripMenuItem";
            this.修改钱箱密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改钱箱密码ToolStripMenuItem.Text = "修改钱箱密码";
            this.修改钱箱密码ToolStripMenuItem.Click += new System.EventHandler(this.修改钱箱密码ToolStripMenuItem_Click);
            // 
            // 退出QToolStripMenuItem
            // 
            this.退出QToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.退出QToolStripMenuItem.Name = "退出QToolStripMenuItem";
            this.退出QToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.退出QToolStripMenuItem.Text = "退出(&Q)";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtRealName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "卡资料速查";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "重    置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "查    找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(89, 67);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 21);
            this.txtMobile.TabIndex = 2;
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(89, 42);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(100, 21);
            this.txtRealName.TabIndex = 1;
            this.txtRealName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRealName_KeyDown);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 21);
            this.txtID.TabIndex = 0;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "手机号码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓    名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "卡    号：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(686, 52);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::vip_gl.Properties.Resources._1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 49);
            this.toolStripButton1.Text = "消  费(&S)";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::vip_gl.Properties.Resources._2;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 49);
            this.toolStripButton2.Text = "查  询(&Q)";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::vip_gl.Properties.Resources._3;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(57, 49);
            this.toolStripButton3.Text = "密  码(&M)";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::vip_gl.Properties.Resources._4;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 49);
            this.toolStripButton4.Text = "开钱箱(&O)";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::vip_gl.Properties.Resources._5;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(57, 49);
            this.toolStripButton5.Text = "退  出(&Q)";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::vip_gl.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(686, 497);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 会员卡管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发卡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消费结算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 积分规则ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结转日志ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开钱箱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改钱箱密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;

    }
}