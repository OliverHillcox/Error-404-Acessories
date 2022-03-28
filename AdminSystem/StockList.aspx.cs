using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStocks();
        }
    }

    void DisplayStocks()
    {
        clsStockCollection stocks = new clsStockCollection();
        lstStockList.DataSource = stocks.StockList;
        lstStockList.DataValueField = "ItemID";
        lstStockList.DataTextField = "ItemName";
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ItemID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }
}