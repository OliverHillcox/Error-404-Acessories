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

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 itemID;
        if (lstStockList.SelectedIndex != -1)
        {
            itemID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ItemID"] = itemID;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
        
    }
}