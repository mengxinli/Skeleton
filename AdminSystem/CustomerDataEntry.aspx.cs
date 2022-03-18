using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class CustomerDataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Submit(object sender, EventArgs e)
    {
        clsCustomer CustomerMember = new clsCustomer();

        CustomerMember.UserName = TextBoxUserName.Text;

        CustomerMember.PassWord = Convert.ToInt32(TextBoxPassWord.Text);

        CustomerMember.PhoneNumber = Convert.ToInt32(TextBoxPhoneNumber.Text);

        CustomerMember.UserId = Convert.ToInt32(TextBoxUserId.Text);

        CustomerMember.DateAdded = Convert.ToDateTime(TextBoxDateAdded.Text);

        Session["CustomerMember"] = CustomerMember;
        Response.Redirect("CustomerViewer.aspx");
    }
    protected void Back(object sender, EventArgs e)
    {
        Response.Redirect("CustomerViewer.aspx");
    }



    protected void btnFind(object sender, EventArgs e)
    {
        clsCustomer CustomerMember = new clsCustomer();
        Int32 UserId;
        Boolean Found = false;
        UserId = Convert.ToInt32(TextBoxUserId.Text);
        Found = CustomerMember.Find(UserId);
        if (Found == true)
        {
            TextBoxDateAdded.Text = CustomerMember.DateAdded.ToString();
            TextBoxUserName.Text = CustomerMember.UserName.ToString();
        }
    }
}
