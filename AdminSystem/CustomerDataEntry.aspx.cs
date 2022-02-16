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
        ACustomer.Active = chkOver18.Checked;
        ACustomer.Name = txtCustomerName.Text;

        string[] birthdayArray = txtBirthday.Text.Split('/');
        ACustomer.Birthday =  new DateTime(Int32.Parse(birthdayArray[2]), Int32.Parse(birthdayArray[1]), Int32.Parse(birthdayArray[0]));

        ACustomer.Address = txtAddress.Text;
        ACustomer.PostCode = txtPostCode.Text;
        ACustomer.PhoneNumber = txtPhoneNumber.Text;
        ACustomer.EmailAddress = txtEmailAddress.Text;

        Session["ACustomer"] = ACustomer;

        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerDataEntry.aspx");
    }
}