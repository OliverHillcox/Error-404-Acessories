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
            clsDataConnection DB = new clsDataConnection();

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

        public string Valid(string name, string birthday, string emailAddress, string address, string postcode, string phoneNumber, string over18)
        {
            String Error = "";
            DateTime DateTemp;

            if (name.Length == 0)
            {
                Error = Error + "The name may not be blank : ";
            }
            //grater than 50 chars
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters : ";
            }

            try
            {
                //check to see if the date is grater than today's date
                DateTemp = Convert.ToDateTime(birthday);
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }

                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    Error = Error + "The date cannot be that far in the past";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            if (emailAddress.Length == 0)
            {
                Error = Error + "The emailAddress cannot not be empty: ";
            }
            if (emailAddress.Length > 50)
            {
                Error = Error + "The emailAddress must be less than 50 chars: ";
            }

            if (address.Length == 0)
            {
                Error = Error + "The address cannot not be empty: ";
            }
            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 chars: ";
            }

            if (phoneNumber.Length == 0)
            {
                Error = Error + "The phoneNumber may not be blank";
            }
            if (phoneNumber.Length > 50)
            {
                Error = Error + "The phoneNumber must be less than 50 characters : ";
            }

            if (postcode.Length == 0)
            {
                Error = Error + "The postcode may not be blank";
            }
            if (postcode.Length > 9)
            {
                Error = Error + "The postcode must be less than 9 characters : ";
            }

            //return any error message
            return Error;
        }
    }
}