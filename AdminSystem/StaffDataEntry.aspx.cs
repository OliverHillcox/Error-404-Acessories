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
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();

        //capture the Name
        AnStaff.Name = txtName.Text;
        AnStaff.Phone = txtPhone.Text;
        AnStaff.Address = txtAddress.Text;
        AnStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        AnStaff.StartedDate = Convert.ToDateTime(txtStartedDate.Text);
        AnStaff.Salary = Convert.ToDouble(txtSalary.Text);
        AnStaff.Intern = chkIntern.Checked;

        //store the address in the seesion object
        Session["AnStaff"] = AnStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");


    }

    protected void txtPhone_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //variable to store the primary key
        Int32 StaffId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key rntered by the user
        StaffId = Convert.ToInt32( txtStaffId.Text);
        //fins the record
        Found = AnStaff.Find(StaffId);
        //if Found
        if (Found == true)
        {
            //display the value of the properties in the form
            txtName.Text = AnStaff.Name;
            txtPhone.Text = AnStaff.Phone;
            txtAddress.Text = AnStaff.Address;
            txtStartedDate.Text = AnStaff.StartedDate.ToString();
            txtSalary.Text = AnStaff.Salary.ToString();
        }
    }
}