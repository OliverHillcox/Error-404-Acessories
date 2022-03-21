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

        clsCustomer ACustomer = new clsCustomer();

        string Active = chkOver18.Checked.ToString();
        string Name = txtCustomerName.Text;

        string[] birthdayArray = txtBirthday.Text.Split('/');

        string Birthday = txtBirthday.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string EmailAddress = txtEmailAddress.Text;

        string Error = "";
        Error = ACustomer.Valid(Name, Birthday, EmailAddress, Address, PostCode, PhoneNumber, Active);

        if(Error == "")
        {
            ACustomer.Active = chkOver18.Checked;
            ACustomer.Name = Name;
            ACustomer.Birthday = Convert.ToDateTime(Birthday);
            ACustomer.PostCode = PostCode;
            ACustomer.PhoneNumber = PhoneNumber;
            ACustomer.EmailAddress = EmailAddress;

            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }



    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void Find_Click(object sender, EventArgs e)
    {
         clsCustomer ACustomer = new clsCustomer();

        Int32 CustomerID;

        Boolean Found = false;

        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        Found = ACustomer.Find(CustomerID);

        if(Found)
        {
            txtAddress.Text = ACustomer.Address;
            txtBirthday.Text = ACustomer.Birthday.ToString();
            txtCustomerName.Text = ACustomer.Name;
            txtEmailAddress.Text = ACustomer.EmailAddress;
            txtPhoneNumber.Text = ACustomer.PhoneNumber;
            txtPostCode.Text = ACustomer.PostCode;

        }



    }
}