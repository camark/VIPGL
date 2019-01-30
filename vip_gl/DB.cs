using System;
using System.Data;
using System.Data.OleDb;

namespace vip_gl
{

    internal class DB
    {
        private string sqlText;

        public DB()
        {
        }

        public DB(string sqlText)
        {
            this.sqlText = sqlText;
        }

        public bool adddellog(string m_id, string dellog)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into jsdellog(m_id,dellog) values('" + m_id + "','" + dellog + "')", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool addintegral(string member_id, double in_money, string js_one, string bz)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand(string.Concat(new object[] { "insert into integral(member_id,in_money,js_one,bz) values('", member_id, "',", in_money, ",'", js_one, "','", bz, "')" }), con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool addmember(string id, string mem_name, string sex, string sfz, string mobile, string tel, string birthday, string addr, string com)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("insert into members(id,mem_name,sex,sfz,mobile,tel,birthday,addr,com) values('" + id + "','" + mem_name + "','" + sex + "','" + sfz + "','" + mobile + "','" + tel + "','" + birthday + "','" + addr + "','" + com + "')", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool checkidsingle(string id)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select count(*) from members where id='" + id + "'", con);
            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool deloperator()
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            int f = new OleDbCommand(this.sqlText, con).ExecuteNonQuery();
            con.Close();
            if (f > 0)
            {
                Flag = true;
            }
            return Flag;
        }

        public DataSet ds()
        {
            OleDbConnection con = oledbCreate();
            OleDbDataAdapter sda = new OleDbDataAdapter();
            sda.SelectCommand = new OleDbCommand(this.sqlText, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "table");
            return ds;
        }

        public bool editBset(string cid, string title)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update basictb set title='" + title + "' where cid='" + cid + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool editID(string id, string id2)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update members set id='" + id2 + "' where id='" + id + "'", con);
            OleDbCommand cmd2 = new OleDbCommand("update integral set member_id='" + id2 + "' where member_id='" + id + "'", con);
            int f = cmd.ExecuteNonQuery();
            int f2 = cmd2.ExecuteNonQuery();
            if ((f > 0) || (f2 > 0))
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool editjsg(string cid, int jfmoneytoint, int jfinout, int todate)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand(string.Concat(new object[] { "update basictb set jfmoneytoint=", jfmoneytoint, ",jfinout=", jfinout, ",todate=", todate, " where cid='", cid, "'" }), con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool editmember(string id, string mem_name, string sex, string sfz, string mobile, string tel, string birthday, string addr, string com, DateTime adddate)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand(string.Concat(new object[] { 
                "update members set mem_name='", mem_name, "',sex='", sex, "',sfz='", sfz, "',mobile='", mobile, "',tel='", tel, "',birthday='", birthday, "',addr='", addr, "',com='", com, 
                "',adddate='", adddate, "' where id='", id, "'"
             }), con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool editpwd(string userid, string userpwd)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update users set userpwd='" + userpwd + "' where userid='" + userid + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public bool editpwd2(string userid, string opwd)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update opwd set opwd='" + opwd + "' where userid='" + userid + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }

        public OleDbDataReader getDr(string id)
        {
            OleDbConnection con = oledbCreate();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbCommand cmd = new OleDbCommand("select * from members where id = '" + id + "'  order by adddate desc", con);
            return cmd.ExecuteReader();
        }

        public OleDbDataReader getDr(string id, string realname, string mobile)
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            string strSql = "";
            if (id != "")
            {
                strSql = "select * from members where id like '%" + id + "%' order by adddate desc";
            }
            else if (realname != "")
            {
                strSql = "select * from members where mem_name like '%" + realname + "%' order by adddate desc";
            }
            else if (mobile != "")
            {
                strSql = "select * from members where  mobile like '%" + mobile + "%' order by adddate desc";
            }
            else
            {
                strSql = "select * from members order by adddate desc";
            }
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            return cmd.ExecuteReader();
        }

        public OleDbDataReader getDr2(string cid)
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from basictb where cid = '" + cid + "'", con);
            return cmd.ExecuteReader();
        }

        public OleDbDataReader getDr3(string id)
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select a.id,a.mem_name,a.sfz,a.mobile,a.tel,a.birthday,a.addr,a.com,a.indate,a.adddate as a_adddate,b.member_id,b.in_money,b.js_one,b.adddate,b.bz from members a left join integral b on a.id=b.member_id where b.member_id='" + id + "' order by a.adddate desc", con);
            return cmd.ExecuteReader();
        }

        public OleDbDataReader getDr4(string id, string realname, string mobile)
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            string strSql = "";
            if (id != "")
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,b.adddate as a_adddate,a.member_id,a.in_money,a.js_one,a.adddate,a.bz from  integral a  left join members b on b.id=a.member_id where a.member_id = '" + id + "'  order by a.adddate desc";
            }
            else if (realname != "")
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,b.adddate as a_adddate,a.member_id,a.in_money,a.js_one,a.adddate,a.bz from  integral a  left join members b on b.id=a.member_id  where b.mem_name = '" + realname + "'  order by a.adddate desc";
            }
            else if (mobile != "")
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,b.adddate as a_adddate,a.member_id,a.in_money,a.js_one,a.adddate,a.bz from  integral a  left join members b on b.id=a.member_id  where b.mobile = '" + mobile + "'  order by a.adddate desc";
            }
            else
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,b.adddate as a_adddate,a.member_id,a.in_money,a.js_one,a.adddate,a.bz from  integral a  left join members b on b.id=a.member_id  order by a.adddate desc";
            }
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            return cmd.ExecuteReader();
        }

        public OleDbDataReader getDr5(string id, string realname, string mobile)
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            string strSql = "";
            if (id != "")
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,a.dellog,a.adddate from  jsdellog a  left join members b on b.id=a.m_id where a.m_id = '" + id + "'  order by a.adddate desc";
            }
            else if (realname != "")
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,a.dellog,a.adddate  from jsdellog a  left join members b on b.id=a.m_id where b.mem_name = '" + realname + "'  order by a.adddate desc";
            }
            else if (mobile != "")
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,a.dellog,a.adddate  from jsdellog a  left join members b on b.id=a.m_id where b.mobile = '" + mobile + "'  order by a.adddate desc";
            }
            else
            {
                strSql = "select b.id,b.mem_name,b.sfz,b.mobile,b.tel,b.birthday,b.addr,b.com,b.indate,a.dellog,a.adddate from  jsdellog a  left join members b on b.id=a.m_id  order by a.adddate desc";
            }
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            return cmd.ExecuteReader();
        }

        public double getonejs(string id)
        {
            double js = 0.0;
            OleDbConnection con = oledbCreate();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                js = Convert.ToDouble(new OleDbCommand("select sum(js_one) from integral where member_id = '" + id + "'", con).ExecuteScalar());
            }
            catch
            {
                js = 0.0;
                con.Close();
            }
            return js;
        }

        public double getonejs(string id, string realname, string mobile)
        {
            try
            {
                OleDbConnection con = oledbCreate();
                con.Open();
                string strSql = "";
                if (id != "")
                {
                    strSql = "select sum(js_one) from integral where member_id = '" + id + "'";
                }
                else if (realname != "")
                {
                    strSql = "select sum(js_one) from integral a left join members b on b.id=a.member_id where b.mem_name = '" + realname + "'";
                }
                else if (mobile != "")
                {
                    strSql = "select sum(js_one) from integral a left join members b on b.id=a.member_id where b.mobile = '" + mobile + "'";
                }
                OleDbCommand cmd = new OleDbCommand(strSql, con);
                return Convert.ToDouble(cmd.ExecuteScalar());
            }
            catch
            {
                return 0.0;
            }
        }

        public string getopwd(string userid)
        {
            string str = "";
            OleDbConnection con = oledbCreate();
            con.Open();
            str = Convert.ToString(new OleDbCommand("select opwd from opwd where userid='" + userid + "'", con).ExecuteScalar());
            con.Close();
            return str;
        }

        public string getrealname(string userid)
        {
            string str = "";
            OleDbConnection con = oledbCreate();
            con.Open();
            str = Convert.ToString(new OleDbCommand("select realname from users where userid='" + userid + "'", con).ExecuteScalar());
            con.Close();
            return str;
        }

        public bool login()
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            int f = Convert.ToInt32(new OleDbCommand(this.sqlText, con).ExecuteScalar());
            con.Close();
            if (f > 0)
            {
                Flag = true;
            }
            return Flag;
        }

        public static OleDbConnection oledbCreate()
        {
            string strConnection = "Provider=Microsoft.Jet.OleDb.4.0;";
            return new OleDbConnection(strConnection + "Data Source=vip.mdb");
        }

        public bool operation()
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            new OleDbCommand(this.sqlText, con).ExecuteNonQuery();
            con.Close();
            return true;
        }

        public string str()
        {
            OleDbConnection con = oledbCreate();
            con.Open();
            string str = Convert.ToString(new OleDbCommand(this.sqlText, con).ExecuteScalar());
            con.Close();
            return str;
        }

        public bool zeroJf(string id)
        {
            bool Flag = false;
            OleDbConnection con = oledbCreate();
            con.Open();
            OleDbCommand cmd = new OleDbCommand("update integral set js_one='0' where member_id='" + id + "'", con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Flag = true;
            }
            con.Close();
            return Flag;
        }
    }
}

