using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["AddressNo"]);
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.ThisStaff.Find(StaffId);

        txtStaffId.Text = StaffList.ThisStaff.StaffId.ToString();
        txtName.Text = StaffList.ThisStaff.StaffId.StaffName;
        txtUsername.Text = StaffList.ThisStaff.StaffId.StaffUsername;
        txtPassword.Text = StaffList.ThisStaff.StaffId.StaffPassword;
        txtRole.Text = StaffList.ThisStaff.StaffId.StaffRole;
        txtSalary.Text = StaffList.ThisStaff.StaffId.StaffSalary;
        txtDateAdded.Text = StaffList.ThisStaff.StaffId.StaffDateAdded.ToString();
        chkStaffMngr.Checked = StaffList.ThisStaff.StaffMngr;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff staffMember = new clsStaff();
        //capture the first name
        string StaffName = txtName.Text;
        string StaffUsername = txtUsername.Text;
        string StaffPassword = txtPassword.Text;
        string StaffSalary = txtSalary.Text;
        string StaffRole = txtRole.Text;
        string StaffDateAdded = txtDateAdded.Text;
        string Error = "";
        Error = staffMember.Valid(StaffName, StaffUsername, StaffPassword, StaffSalary, StaffRole, StaffDateAdded);       
        if (Error == "")
        {

            staffMember.StaffName = StaffName;

            staffMember.StaffUsername = StaffUsername;

            staffMember.StaffPassword = StaffPassword;

            staffMember.StaffSalary = Convert.ToInt32(StaffSalary);

            staffMember.StaffRole = StaffRole;

            staffMember.StaffDateAdded = Convert.ToDateTime(StaffDateAdded);

            staffMember.StaffMngr = chkStaffMngr.Checked;

            clsStaffCollection StaffList = new clsStaffCollection();

            if (StaffId == -1)
            {
                StaffList.ThisStaff = staffMember;
                StaffList.Add();
            }

            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = staffMember;
                StaffList.Update();
            }
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
        else
        {
            txtStaffId.text = "No Staff with that ID";
        }
    }
}