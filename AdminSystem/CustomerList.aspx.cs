using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCustomer();
        }
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        lstCustomerList.DataSource = Customers.CustomerList;

        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;

        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please seelct a Record to edit from the list";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please seelct a Record to delete from the list";
        }
    }

    protected void ApplyButton(object sender, EventArgs e)
    {
        clsCustomerCollection customerCollection = new clsCustomerCollection();

        customerCollection.ReportByPostCode(postcode.Text);

        lstCustomerList.DataSource = customerCollection.CustomerList;

        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "PostCode";

        lstCustomerList.DataBind();

    }

    protected void ClearButton(object sender, EventArgs e)
    {
        clsCustomerCollection customerCollection = new clsCustomerCollection();

        customerCollection.ReportByPostCode("");

        lstCustomerList.DataSource = customerCollection.CustomerList;

        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "PostCode";

        lstCustomerList.DataBind();
    }
}