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
        clsStock AnStock = new clsStock();
        AnStock.name = TextBoxName.Text;
        AnStock.quantity = int.Parse(TextBoxQuantity.Text)-10;
        Session["AnStock"] = AnStock;
        //Response.Write(AnStock.quantity + '\n' + AnStock.name);
        Response.Redirect("StockViewer.aspx");
    }
    protected void GoBack(object sender, EventArgs e)
    {
        Response.Redirect("StockViewer.aspx");
    }
}