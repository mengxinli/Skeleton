using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();

        staffMember.StaffId = Convert.ToInt32(txtStaffId.Text);
        
        staffMember.StaffName = txtName.Text;
        
        staffMember.StaffUsername = txtUsername.Text;
        
        staffMember.StaffPassword = txtPassword.Text;
        
        staffMember.StaffSalary = Convert.ToInt32(txtSalary.Text);
        
        staffMember.StaffRole = txtRole.Text;

        staffMember.StaffDateAdded = Convert.ToDateTime(txtDateAdded);
        
        Session["staffMember"] = staffMember;
        Response.Redirect("StaffManagementViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = staffMember.Find(StaffId);
        if (Found == true)
        {
            txtName.Text = StaffId.StaffName;
            txtUsername.Text = StaffId.StaffUsername;
            txtPassword.Text = StaffId.StaffPassword;
            txtRole.Text = StaffId.StaffRole;
            txtSalary.Text = StaffId.StaffSalary;
            txtDateAdded.Text = StaffId.StaffDateAdded.ToString();
        }
    }