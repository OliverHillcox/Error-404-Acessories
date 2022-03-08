using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;

        public Int32 CustomerID
        {
            get {return mCustomerID;}
            set {mCustomerID = value;}
        }

        private bool mActive;
        public bool Active
        {
            get {return mActive;} 
            set { mActive = value; }
        }

        private DateTime mBirthday;
        public DateTime Birthday {
            get {return mBirthday;}
            set { mBirthday = value;}
        }

        private string mName;
        public string Name { 
            get { return mName; }
            set { mName = value; }
        }

        private string mPhoneNumber;
        public string PhoneNumber {
            get { return mPhoneNumber; }
            set { mPhoneNumber = value; }
        }

        private string mEmailAddress;
        public string EmailAddress { 
            get { return mEmailAddress; }
            set { mEmailAddress = value; }
        }

        private string mPostCode;
        public string PostCode {
            get { return mPostCode; }
            set { mPostCode = value; }
        }

        private string mAddress;
        public string Address { 
            get { return mAddress; }
            set { mAddress = value; }
        }


        //methods

        public bool Find(int customerID)
        {
            clsDataConnection DB = new clsDataConnection("");

            DB.AddParameter("@CustomerID", customerID);

            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            if (DB.Count == 1)
            {

                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                mBirthday = Convert.ToDateTime(DB.DataTable.Rows[0]["Birthday"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);

                return true;
            }

            else { return false; }

        }
    }
}