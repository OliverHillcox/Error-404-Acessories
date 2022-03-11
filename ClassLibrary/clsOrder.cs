﻿using System;

namespace ClassLibrary
{
    public class clsOrder
    {

        //Dispatched private member variable
        private Boolean mDispatched;
        //Dispatched public property
        public bool Dispatched
        {
            get
            {
                //code sends data out of the property
                return mDispatched;
            }
            set
            {
                mDispatched = value;
            }
        }

        //DateofPurchase private member variable
        private DateTime mDateofPurchase;
        public DateTime DateofPurchase
        {
            get
            {
                //CODE SENDS DATA OUT OF THE PROPERTY
                return mDateofPurchase;
            }
            set
            {
                //set the private data
                mDateofPurchase = value;
            }
        }

        //Address private member variable
        private string mAdddress;
        //Address public property
        public string Address
        {
            get
            {
                //code sends data out of the property
                return mAdddress;
            }
            set
            {
                //sets the private data
                mAdddress = value;
            }
        }

        //OrderPrice private member variable
        private double mOrderPrice;
        //OrderPrice public property
        public double OrderPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderPrice;
            }
            set
            {
                //set the private data
                mOrderPrice = value;
            }
        }


        //OrderQnty private member variable
        private Int32 mOrderQnty;
        //OrderQnty public property
        public int OrderQnty
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderQnty;

            }
            set
            {
                //set the private data
                mOrderQnty = value;
            }
        }

        //OrderNo private data member for the address no property
        private Int32 mOrderNo;
        //OrderNo public property 
        public int OrderNo
        {
            get
            {
                //this line of code sends data out of the propety
                return mOrderNo;
            }
            set
            {
                //set the private data
                mOrderNo = value;
            }
        }


        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mOrderPrice = Convert.ToDouble(DB.DataTable.Rows[0]["OrderPrice"]);
                mOrderQnty = Convert.ToInt32(DB.DataTable.Rows[0]["OrderQnty"]);
                mDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["Dispatched"]);
                mDateofPurchase = Convert.ToDateTime(DB.DataTable.Rows[0]["DateofPurchase"]);
                mAdddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);

                //return that everything worked ok
                return true;
            }

            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

    }
}










            