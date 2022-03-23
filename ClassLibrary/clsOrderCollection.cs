using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry  about this later
            }
        }

        public clsOrder ThisOrder { get; set; }

        //constructor for the class
        public clsOrderCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to  store the record count
            Int32 RecordCount = 0;
            //object for data collection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrder.OrderQnty = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderQnty"]);
                AnOrder.OrderPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.Dispatched = Convert.ToBoolean(DB.DataTable.Rows[Index]["Dispatched"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnOrder.DateofPurchase = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofPurchase"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }

        }
    }
}

