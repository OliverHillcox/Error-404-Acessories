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

        public bool Find(int StaffId)
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
        
        //function for the public validation method
        public string Valid(string name, string startedDate, string address, string phone)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the Name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the name is grater than 50 characters
            if (name.Length > 50)
            {
                //record the error
                Error = Error + "The name must be less than 50 characters : ";
            }

            try
            {
                //copy the StartedDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(startedDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past";
                }

                //check to see if the date is grater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "StartedDate must be valid. ";
            }

            if (address.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }
            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 characters : ";
            }

            if (phone.Length == 0)
            {
                Error = Error + "The phone may not be blank";
            }
            if (phone.Length > 50)
            {
                Error = Error + "The phone must be less than 50 characters : ";
            }


            //return any error message
            return Error;
        }
    }
}