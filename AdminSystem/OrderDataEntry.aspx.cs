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
        string Address = txtAddress.Text;

        string DateofPurchase = txtDateOfPurchase.Text;
        string Error = "";
        Error = AnOrder.Valid(Address, DateofPurchase);
        if (Error == "")
        {
            AnOrder.Address = Address;
            AnOrder.DateofPurchase = Convert.ToDateTime(DateofPurchase);
        
        //navigate to the viewer page
        Session["AnOrder"] = AnOrder;
        Response.Write("OrderViewer.aspx");
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

