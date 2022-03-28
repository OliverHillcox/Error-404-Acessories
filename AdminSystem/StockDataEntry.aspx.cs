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
            someStock.ItemID = Int32.Parse(txtItemID.Text);
            someStock.ItemName = txtItemName.Text;
            someStock.ItemOver18 = txtItemOver18.Checked;
            someStock.ItemQuantity = Int32.Parse(txtItemQuantity.Text);
            someStock.ItemDateAdded = Convert.ToDateTime(txtItemDateAdded.Text);
            someStock.ItemPrice = Convert.ToDouble(txtItemPrice.Text);

            clsStockCollection StockList = new clsStockCollection();
            StockList.ThisStock = someStock;
            StockList.Add();
            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");
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