using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 itemid;

    protected void Page_Load(object sender, EventArgs e)
    {
        itemid = Convert.ToInt32(Session["ItemID"]);
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection allstock = new clsStockCollection();
        allstock.ThisStock.Find(itemid);
        allstock.Delete();
        Response.Redirect("StockList.aspx");
    }
}