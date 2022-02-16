using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        ACustomer = (clsCustomer)Session["ACustomer"];

        Response.Write(ACustomer.Name);
        Response.Write("<br/>");
        Response.Write(ACustomer.EmailAddress);
        Response.Write("<br/>");
        Response.Write(ACustomer.Address);
        Response.Write("<br/>");
        Response.Write(ACustomer.PostCode);
        Response.Write("<br/>");
        Response.Write(ACustomer.Birthday.ToString().Split(' ')[0]);
        Response.Write("<br/>");
        Response.Write(ACustomer.PhoneNumber);
        Response.Write("<br/>");
        Response.Write(ACustomer.Active);

    }
}