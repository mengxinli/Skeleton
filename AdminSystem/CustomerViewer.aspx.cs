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

        Response.Write("User Name: " + CustomerMember.UserName + "<br />");

        Response.Write("Pass Word: " + CustomerMember.PassWord + "<br />");

        Response.Write("Phone Number: " + CustomerMember.PhoneNumber + "<br />");

        Response.Write("User Id: " + CustomerMember.UserId + "<br />");

        Response.Write("Date : " + CustomerMember.DateAdded + "<br />");
    }

    protected void CustomerDataEntryButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDataEntry.aspx");
    }
}
