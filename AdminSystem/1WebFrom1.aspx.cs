using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace work
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //login
        protected void Button2_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string pwd = TextBox2.Text;
            if (name != null || pwd != null)
            {
                string sql = "select count(0) from student where stuName=@a and stuNo=@b";//Get data information
                SqlParameter p1 = new SqlParameter("@a", name);
                SqlParameter p2 = new SqlParameter("@b", pwd);
                //connect database
                string connStr = "server=DESKTOP-QQGOIKH;uid=sa;pwd=123;database=stuDB";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                object obj = cmd.ExecuteScalar();
                conn.Close();
                int i = (int)obj;
                if (i > 0)
                {
                    Response.Redirect("WebForm2.aspx");
                }
                else
                {
                    Response.Write("login failed");
                }
            }
            else
            {
                return;
            }


        }
        //register
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("1WebForm2.aspx");

        }
    }
}