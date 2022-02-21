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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the address
        AnOrder.Address = txtAddress.Text;
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.OrderQnty = Convert.ToInt32(txtOrderQnty.Text);
        AnOrder.OrderPrice = Convert.ToDouble(txtOrderPrice.Text);
        AnOrder.DateofPurchase = Convert.ToDateTime(txtDateOfPurchase.Text);
        AnOrder.Dispatched = chkDispatched.Checked;
        
        //navigate to the viewer page
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    

    }
}
