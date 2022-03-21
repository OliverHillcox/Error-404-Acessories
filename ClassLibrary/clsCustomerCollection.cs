using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList { get { return mCustomerList; } set { mCustomerList = value; } }
        public int Count { get { return mCustomerList.Count; } set { } }
        public clsCustomer ThisCustomer { get; set; }


        public clsCustomerCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB= new clsDataConnection();

            DB.Execute("sproc_Customer_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer Customer = new clsCustomer();

                Customer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                Customer.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                Customer.Birthday = Convert.ToDateTime(DB.DataTable.Rows[0]["Birthday"]);
                Customer.Name = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                Customer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                Customer.EmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                Customer.PostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                Customer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);

                mCustomerList.Add(Customer);

                Index++;

            }


        }
    }
}