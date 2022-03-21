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

        //capture the properties
        string Name = txtName.Text;
        string Phone = txtPhone.Text;
        string Address = txtAddress.Text;
        string StaffId = txtStaffId.Text;
        string StartedDate = txtStartedDate.Text;
        string Salary = txtSalary.Text;

        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(Name, Phone, Address, StartedDate);
        if (Error == "")
        {
            AnStaff.Name = Name;
            AnStaff.Phone = Phone;
            AnStaff.Address = Address;
            AnStaff.StaffId = Convert.ToInt32(StaffId);
            AnStaff.Salary = Convert.ToDouble(Salary);
            AnStaff.StartedDate = Convert.ToDateTime(StartedDate);
            //store the address in the seesion object
            Session["AnStaff"] = AnStaff;
            //navigate to the viewer page
            Response.Write("StaffViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

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