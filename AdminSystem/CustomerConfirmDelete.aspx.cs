using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomerCollection customerList = new clsCustomerCollection();
        customerList.ThisCustomer.Find(CustomerID);
        customerList.Delete();

        Response.Redirect("CustomerList.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}