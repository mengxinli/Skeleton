﻿using System;
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
        AnStock.Id = Convert.ToInt32(TextBoxID.Text);
        AnStock.Name = TextBoxName.Text;
        AnStock.Quantity = Convert.ToInt32(TextBoxQuantity.Text);
        AnStock.Type = TextBoxType.Text;
        AnStock.Remark = TextBoxRemark.Text;
        if (TextBoxTime.Text.Length == 0)
            AnStock.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        else
            AnStock.Time = Convert.ToDateTime(TextBoxTime.Text).ToString();
        Session["AnStock"] = AnStock;
        //Response.Write(AnStock.quantity + '\n' + AnStock.name);
        Response.Redirect("StockViewer.aspx");
    }
    protected void GoBack(object sender, EventArgs e)
    {
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind(object sender, EventArgs e)
    {
        clsStock clsStock = new clsStock();
        Int32 Id;
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