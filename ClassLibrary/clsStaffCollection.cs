using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sprc_tblStaff_SellectAll");
            //get the count of record
            RecordCount = DB.Count;

            //while there are record to process
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                //read in the field from the current record
                AnStaff.Intern = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnStaff.StartedDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartedDate"]);

                mStaffList.Add(AnStaff);

                Index++;
       
            } 



/*
            //create item for trst data
            clsStaff TestItem = new clsStaff();
            //set its property
            TestItem.Intern = true;
            TestItem.StaffId = 1;
            TestItem.Salary = 20000.00;
            TestItem.Name = "john";
            TestItem.Address = "132 something close";
            TestItem.Phone = "324 463 355";
            TestItem.StartedDate = DateTime.Now.Date;
            //add the item to the test list
            mStaffList.Add(TestItem);

            //re initialisation the object for some new data
            TestItem = new clsStaff();
            //set its property
            TestItem.Intern = true;
            TestItem.StaffId = 2;
            TestItem.Salary = 20000.00;
            TestItem.Name = "christy";
            TestItem.Address = "123 Another close";
            TestItem.Phone = "123 456 789";
            TestItem.StartedDate = DateTime.Now.Date;
            //add the item to the test list
            mStaffList.Add(TestItem); */
        }



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
    }
}