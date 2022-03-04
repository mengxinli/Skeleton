using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDataEntry : System.Web.UI.Page
{
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
    }
}
