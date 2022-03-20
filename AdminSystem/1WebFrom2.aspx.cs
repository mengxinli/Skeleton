using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace work
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //注册
        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string pwd = TextBox2.Text;
            if (name != null || pwd != null)
            {
                string sql = "insert into enter values(@a,@b)";
                SqlParameter[] sp = new SqlParameter[2];
                sp[0] = new SqlParameter("@a", TextBox1.Text);
                sp[1] = new SqlParameter("@b", TextBox2.Text);
                SqlConnection conn = new SqlConnection("server=STER-PC;uid=sa;pwd=123;database=t2");
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddRange(sp);//add 
                int i = comm.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    Response.Write("register successful");
                }
                else
                {
                    Response.Write("register failed");
                }
            }
            else
            {
                Response.Write("请填写内容");
            }
        }
        //返回
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("1WebForm1.aspx");
        }
    }
}