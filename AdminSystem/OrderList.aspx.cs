using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if this the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrder();
        }
    }

    private void DisplayOrder()
    {
        //create an instance of the Order collection
        clsOrderCollection Order = new clsOrderCollection();
        //set the data source to list of order in the collection
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderNo";
        //set the data field to display
        lstOrderList.DataTextField = "Address";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNo"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderNo;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderNo"] = OrderNo;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
        }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Order = new clsOrderCollection();
        Order.ReportByAddress(txtFilter.Text);
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderNo";
        //set the name of the field to display
        lstOrderList.DataTextField = "Address";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the address collection
        clsOrderCollection Order = new clsOrderCollection();
        Order.ReportByAddress("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstOrderList.DataSource = Order.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderNo";
        //set the name of the field to display
        lstOrderList.DataTextField = "Address";
        //bind the data to the list
        lstOrderList.DataBind();
    }
}
