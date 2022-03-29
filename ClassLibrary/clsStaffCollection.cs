using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();



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
        public clsStaff ThisStaff { get; set; }


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

    }
}