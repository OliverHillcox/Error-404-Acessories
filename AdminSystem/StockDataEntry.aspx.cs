using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 itemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            itemID = Convert.ToInt32(Session["ItemID"]);
            
            if (itemID != -1)
            {
                DisplayStocks();
            }
        }
    }

    void DisplayStocks()
    {
        clsStockCollection stocks = new clsStockCollection();
        stocks.ThisStock.Find(itemID);
        txtItemID.Text = stocks.ThisStock.ItemID.ToString();
        txtItemDateAdded.Text = stocks.ThisStock.ItemDateAdded.ToString();
        txtItemName.Text = stocks.ThisStock.ItemName;
        txtItemOver18.Checked = stocks.ThisStock.ItemOver18;
        txtItemPrice.Text = stocks.ThisStock.ItemPrice.ToString();
        txtItemQuantity.Text = stocks.ThisStock.ItemQuantity.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock someStock = new clsStock();
        string itemid = txtItemID.Text;
        string itemname = txtItemName.Text;
        string itemover18 = txtItemOver18.Checked.ToString();
        string itemquantity = txtItemQuantity.Text;
        string itemdateadded = txtItemDateAdded.Text;
        string itemprice = txtItemPrice.Text;
        string Error = "";
        Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
        if (Error == "")
        {
            someStock.ItemID = Convert.ToInt32(txtItemID.Text);
            someStock.ItemName = txtItemName.Text;
            someStock.ItemOver18 = txtItemOver18.Checked;
            someStock.ItemQuantity = Int32.Parse(txtItemQuantity.Text);
            someStock.ItemDateAdded = Convert.ToDateTime(txtItemDateAdded.Text);
            someStock.ItemPrice = Convert.ToDouble(txtItemPrice.Text);

            clsStockCollection StockList = new clsStockCollection();
            if (itemID == -1)
            {
                StockList.ThisStock = someStock;
                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(Convert.ToInt32(txtItemID.Text));
                StockList.ThisStock = someStock;
                StockList.Update();
            }
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

    protected void Find_Click(object sender, EventArgs e)
    {
        clsStock someStock = new clsStock();
        Int32 Itemid;
        Boolean Found = false;
        Itemid = Convert.ToInt32(txtItemID.Text);
        Found = someStock.Find(Itemid);
        if (Found == true)
        {
            txtItemName.Text = someStock.ItemName;
            txtItemDateAdded.Text = someStock.ItemDateAdded.ToString();
            txtItemOver18.Text = someStock.ItemOver18.ToString();
            txtItemPrice.Text = someStock.ItemPrice.ToString();
            txtItemQuantity.Text = someStock.ItemQuantity.ToString();

        }
    }
}