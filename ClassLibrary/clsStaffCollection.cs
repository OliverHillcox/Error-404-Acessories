using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //private data member thisStaff
        clsStaff mThisStaff = new clsStaff();



        //public property for staff list
        public List<clsStaff> StaffList {
            get 
            {
                //return private data
                return mStaffList;
            }
            set
            {
                //set private data
                mStaffList = value;
            }
        }

        //public property for count
        public int Count {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                
            }
        }
        public clsStaff ThisStaff 
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }


        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of record
            RecordCount = DB.Count;

            //while there are record to process
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                //read in the field from the current record
                AnStaff.Intern = Convert.ToBoolean(DB.DataTable.Rows[Index]["Intern"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnStaff.StartedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartedDate"]);

                mStaffList.Add(AnStaff);

                Index++;

            }

        }

        public int add()
        {
            //adds a new record to the database based on the values of thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("Intern", mThisStaff.Intern);
            DB.AddParameter("Salary", mThisStaff.Salary);
            DB.AddParameter("Name", mThisStaff.Name);
            DB.AddParameter("Address", mThisStaff.Address);
            DB.AddParameter("Phone", mThisStaff.Phone);
            DB.AddParameter("StartedDate", mThisStaff.StartedDate);

            //execute the quary returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }
}