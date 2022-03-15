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
        clsStock someStock = new clsStock();
        someStock = (clsStock)Session["someStock"];

        Response.Write(someStock.ItemID);
        Response.Write("<br/>");
        Response.Write(someStock.ItemName);
        Response.Write("<br/>");
        Response.Write(someStock.ItemPrice);
        Response.Write("<br/>");
        Response.Write(someStock.ItemDateAdded.ToString());
        Response.Write("<br/>");
        Response.Write(someStock.ItemQuantity);
        Response.Write("<br/>");
        Response.Write(someStock.ItemOver18.ToString());
    }
}