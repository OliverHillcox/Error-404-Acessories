using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the seesion object
        StaffId = Convert.ToInt32(Session["StaffId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();

        Staff.ThisStaff.Find(StaffId);
        //delete the record
        Staff.Delete();

        //redirect
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}