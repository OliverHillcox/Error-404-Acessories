using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        //intern private member variable
        private bool mIntern;
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
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staffId to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data member
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStartedDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartedDate"]);
                mIntern = Convert.ToBoolean(DB.DataTable.Rows[0]["Intern"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]); ;
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]); ;
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]); ;

                //return that everything worked OK
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