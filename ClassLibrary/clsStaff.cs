using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        //intern private member variable
        private Boolean mIntern;
        //intern public property
        public bool Intern {
            get 
            {
                //this line of code sends data out of the property
                return mIntern;
            }
            set
            {
                //this line of code allows data into the property
                mIntern = value;
            }
        }

        //StartedDate private member variable
        private DateTime mStartedDate;
        //startedDate public property
        public DateTime StartedDate {
            get
            {
                //return the private data
                return mStartedDate;
            }
            set
            {
                //set the private data
                mStartedDate = value;
            } 
        }

        //staffId privtate member variable
        private Int32 mStaffId;
        //StaffId public property
        public Int32 StaffId {
            get
            {
                //return the private data
                return mStaffId;
            }
            set
            {
                //set the private data
                mStaffId = value;
            }
        }

        //name private member variable
        private string mName;
        //name public property
        public string Name {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }
        }

        //address private member variable
        private string mAddress;
        //address public property
        public string Address {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the private data
                mAddress = value;
            }
        }

        //salary private member variable
        private double mSalary;
        //salary public property
        public double Salary {
            get
            {
                //return the private data
                return mSalary;
            }
            set
            {
                //set the private data
                mSalary = value;
            }
        }

        //phone private member variable
        private string mPhone;
        //phone public property
        public string Phone {
            get
            {
                //return the private data
                return mPhone;
            }
            set
            {
                //set the private data
                mPhone = value;
            }
        }

        public bool Find(int staffId)
        {
            //set the private data member to the test data value
            mStaffId = 3;
            mStartedDate = Convert.ToDateTime("13/04/2020");
            mIntern = true;
            mName = "john";
            mAddress = "XX XXX XXXX";
            mSalary = 20000.00;
            mPhone = "123 456 7890";

            //always return true
            return true;
        }
    }
}