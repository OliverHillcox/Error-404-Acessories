using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numberof the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            //if this not a new record
            if (StaffId != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //find the record to update
        Staff.ThisStaff.Find(StaffId);

        //display the data for the record
        txtStaffId.Text = Staff.ThisStaff.StaffId.ToString();
        txtName.Text = Staff.ThisStaff.Name;
        txtAddress.Text = Staff.ThisStaff.Address;
        txtSalary.Text = Staff.ThisStaff.Salary.ToString();
        txtPhone.Text = Staff.ThisStaff.Phone;
        txtStartedDate.Text = Staff.ThisStaff.StartedDate.ToString();
        chkIntern.Checked = Staff.ThisStaff.Intern;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();

        //capture the properties
        string Name = txtName.Text;
        string Phone = txtPhone.Text;
        string Address = txtAddress.Text;
        string StartedDate = txtStartedDate.Text;
        string Salary = txtSalary.Text;

        //variable to store any error message
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(Name, Phone, Address, StartedDate);
        if (Error == "")
        {
            AnStaff.StaffId = StaffId;
            AnStaff.Name = Name;
            AnStaff.Phone = Phone;
            AnStaff.Address = Address;
            AnStaff.Intern = chkIntern.Checked;
            AnStaff.Salary = Convert.ToDouble(Salary);
            AnStaff.StartedDate = Convert.ToDateTime(StartedDate);

            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffId = -1 then add the data
            if (StaffId == -1)
            {
                //set the thisStaff property
                StaffList.ThisStaff = AnStaff;
                //add the new record
                StaffList.Add();
            }
            //otherwiseit must be an update
            else
            {
                //find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //set the thisStaff property
                StaffList.ThisStaff = AnStaff;
                //update the record
                StaffList.Update();
            }

            //redirect back to the listpage
            Response.Redirect("StaffList.aspx");

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

    protected void btnCancle_Click(object sender, EventArgs e)
    {

    }

    protected void chkIntern_CheckedChanged(object sender, EventArgs e)
    {

    }
}