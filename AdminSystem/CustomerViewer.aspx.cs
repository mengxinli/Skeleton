using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer CustomerMember = new clsCustomer();
        CustomerMember = (clsCustomer)Session["CustomerMember"];
        Response.Write(CustomerMember.PassWord + '\n' + CustomerMember.UserName);
    }

    protected void CustomerDataEntryButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDataEntry.aspx");
    }
}
