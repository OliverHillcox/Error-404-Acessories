using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList { get { return mCustomerList; } set { mCustomerList = value; } }
        public int Count { get { return mCustomerList.Count; } set { } }

        clsCustomer mThisCustomer = new clsCustomer();
        public clsCustomer ThisCustomer { get { return mThisCustomer; } set { mThisCustomer = value; } }




        public clsCustomerCollection()
        {


            clsDataConnection DB= new clsDataConnection();

            DB.Execute("sproc_Customer_SelectAll");

            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Birthday", mThisCustomer.Birthday);
            DB.AddParameter("@Over18", mThisCustomer.Active);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Postcode", mThisCustomer.PostCode);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Birthday", mThisCustomer.Birthday);
            DB.AddParameter("@Over18", mThisCustomer.Active);
            DB.AddParameter("@PhoneNumber", mThisCustomer.PhoneNumber);
            DB.AddParameter("@EmailAddress", mThisCustomer.EmailAddress);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Postcode", mThisCustomer.PostCode);

            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);

            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByPostCode(String PostCode)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PostCode", PostCode);

            DB.Execute("sproc_tblCustomer_FilterByPostCode");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mCustomerList = new List<clsCustomer>();

            while(Index < RecordCount)
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