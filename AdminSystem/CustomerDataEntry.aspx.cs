using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if(IsPostBack == false)
        {
            if(CustomerID != -1 )
            {
                DisplayAddress();
            }
        }
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

            ACustomer.CustomerID = CustomerID;

            ACustomer.Active = chkOver18.Checked;
            ACustomer.Name = Name;
            ACustomer.Birthday = Convert.ToDateTime(Birthday);
            ACustomer.PostCode = PostCode;
            ACustomer.PhoneNumber = PhoneNumber;
            ACustomer.EmailAddress = EmailAddress;
            ACustomer.Address = Address;

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if(CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }

            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
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

    public void DisplayAddress()
    {
        clsCustomerCollection customerCollection = new clsCustomerCollection();
        customerCollection.ThisCustomer.Find(CustomerID);

        txtAddress.Text = customerCollection.ThisCustomer.Address;
        txtBirthday.Text = customerCollection.ThisCustomer.Birthday.ToString();
        txtCustomerName.Text = customerCollection.ThisCustomer.Name;
        txtEmailAddress.Text = customerCollection.ThisCustomer.EmailAddress;
        txtPhoneNumber.Text = customerCollection.ThisCustomer.PhoneNumber;
        txtPostCode.Text = customerCollection.ThisCustomer.PostCode;

    }
}