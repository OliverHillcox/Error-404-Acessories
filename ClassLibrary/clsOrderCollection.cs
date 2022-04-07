using System;
using System.Collections.Generic;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        //private data member for the list
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
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

        public clsOrder ThisOrder
        {
            get
            {
                //return the private data
                return mThisOrder;
            }
            set
            {
                //set the private data
                mThisOrder = value;
            }
        }


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

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            DB.AddParameter("@OrderQnty", mThisOrder.OrderQnty);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@DateofPurchase", mThisOrder.DateofPurchase);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void ReportByAddress(object text)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@Dispatched", mThisOrder.Dispatched);
            DB.AddParameter("@OrderQnty", mThisOrder.OrderQnty);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@DateofPurchase", mThisOrder.DateofPurchase);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void Delete()
        {
            //delete the record pointed to by thisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderNo", mThisOrder.OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByAddress(string Address)
        {
            //filters the records based on a full or partial address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the address parameter to the database
            DB.AddParameter("@Address", Address);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        
        void PopulateArray(clsDataConnection DB)
        {
            //var for the index
            Int32 Index = 0;
            //var to  store the record count
            Int32 RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
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

