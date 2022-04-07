using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //gett the number of the address to be processed
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderNo != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        //create an instance of the order book
        clsOrderCollection OrderBook = new clsOrderCollection();
        //find the record to update
        OrderBook.ThisOrder.Find(OrderNo);
        //display the data for this record
        txtOrderNo.Text = OrderBook.ThisOrder.OrderNo.ToString();
        txtAddress.Text = OrderBook.ThisOrder.Address;
        txtOrderQnty.Text = OrderBook.ThisOrder.OrderQnty.ToString();
        txtOrderPrice.Text = OrderBook.ThisOrder.OrderPrice.ToString();
        txtDateOfPurchase.Text = OrderBook.ThisOrder.DateofPurchase.ToString();
        chkDispatched.Checked = OrderBook.ThisOrder.Dispatched;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the address
        string Address = txtAddress.Text;
        int OrderQnty = Convert.ToInt32(txtOrderQnty.Text);
        string DateofPurchase = txtDateOfPurchase.Text;
        Double OrderPrice = Convert.ToDouble(txtOrderPrice.Text);
        string Error = "";
        Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
        if (Error == "")
        {
            AnOrder.OrderNo = OrderNo; // dont miss the bit!!
            AnOrder.Address = Address;
            AnOrder.DateofPurchase = Convert.ToDateTime(DateofPurchase);
            AnOrder.OrderQnty = OrderQnty;
            AnOrder.Dispatched = chkDispatched.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();

            // if this is a new record i.e OrderNo = -1 then add the data
            if (OrderNo == -1)
            {
                //set the ThisOrderProperty
                OrderList.ThisOrder = AnOrder;
                //add the new record
                OrderList.Add();
            }

        else
            {
                //find the record to update
                OrderList.ThisOrder.Find(OrderNo);
                //set the ThisOrder property
                OrderList.ThisOrder = AnOrder;
                //update the record
                OrderList.Update();
            }
        
        //navigate to the viewer page
        
        Response.Redirect("OrderList.aspx");
    } 
    else
    {
    //display the error message
    lblError.Text = Error; 
        }
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //vairable to store the primary key
        Int32 OrderNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderNo = Convert.ToInt32(txtOrderNo.Text);
        //find the record
        Found = AnOrder.Find(OrderNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtAddress.Text = AnOrder.Address;
            txtDateOfPurchase.Text = AnOrder.DateofPurchase.ToString();
            txtOrderPrice.Text = AnOrder.OrderPrice.ToString();
            txtOrderQnty.Text = AnOrder.OrderQnty.ToString();

    }
}
}

