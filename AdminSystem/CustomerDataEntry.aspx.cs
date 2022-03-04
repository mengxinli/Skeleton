using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit(object sender, EventArgs e)
    {
        clsCustomer CustomerMember = new clsCustomer();
        CustomerMember.UserName = "Michael Jordan";
        CustomerMember.PassWord = 123456;
        Session["CustomerMember"] = CustomerMember;
        Response.Redirect("CustomerViewer.aspx");
    }
    protected void Back(object sender, EventArgs e)
    {
        Response.Redirect("CustomerViewer.aspx");
    }
}
