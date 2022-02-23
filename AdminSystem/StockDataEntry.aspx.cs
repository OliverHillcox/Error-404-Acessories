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
        someStock.ItemName = txtItemName.Text;
        someStock.ItemOver18 = txtItemOver18.Checked;
        someStock.ItemQuantity = Int32.Parse(txtItemQuantity.Text);
        someStock.ItemDateAdded = Convert.ToDateTime(txtItemDateAdded.Text);
        someStock.ItemPrice = Convert.ToDouble(txtItemPrice.Text);
        Session["someStock"] = someStock;
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");
    }
}