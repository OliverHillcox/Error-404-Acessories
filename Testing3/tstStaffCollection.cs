using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Framework
{
    [TestClass]
    public class tstStaffCollection
    {

        [TestMethod]
        public void InstanceOK()
        {
            //create an insatnce of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if that exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Name = "john";
            TestItem.StaffId = 3;
            TestItem.Phone = "123 456 789";
            TestItem.Intern = true;
            TestItem.Salary = 20000.00;
            TestItem.StartedDate = DateTime.Now.Date;
            TestItem.Address = "213 something close";
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }


        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Intern = true;
            TestStaff.StaffId = 3;
            TestStaff.Salary = 20000.00;
            TestStaff.Name = "john";
            TestStaff.Address = "132 something close";
            TestStaff.Phone = "324 463 355";
            TestStaff.StartedDate = DateTime.Now.Date;
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();

            //create test data
            clsStaff TestItem = new clsStaff();

            //set properties
            TestItem.Intern = true;
            TestItem.StaffId = 1;
            TestItem.Salary = 20000.00;
            TestItem.Name = "john";
            TestItem.Address = "132 something close";
            TestItem.Phone = "324 463 355";
            TestItem.StartedDate = DateTime.Now.Date;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data
            AllStaff.StaffList = TestList;

            //test to see the values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;

            //set its property
            TestItem.Intern = true;
            TestItem.StaffId = 1;
            TestItem.Salary = 20000.00;
            TestItem.Name = "John";
            TestItem.Address = "123 something close";
            TestItem.Phone = "123 456 7890";
            TestItem.StartedDate = DateTime.Now.Date;

            //set thisstaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();

            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Intern = true;
            TestItem.Salary = 18000.00;
            TestItem.Name = "Christy";
            TestItem.Address = "Example address";
            TestItem.Phone = "123 123 1234";
            TestItem.StartedDate = DateTime.Now.Date;

            //set this address to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;

            //modify the test data
            TestItem.Intern = false;
            TestItem.Salary = 19000.00;
            TestItem.Name = "Some name";
            TestItem.Address = "another address";
            TestItem.Phone = "111 222 3333";
            TestItem.StartedDate = DateTime.Now.Date;

            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see thisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();

            //var to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.Intern = true;
            TestItem.StaffId = 1;
            TestItem.Salary = 18000.00;
            TestItem.Name = "Christy22";
            TestItem.Address = "Example address22";
            TestItem.Phone = "123 123 1234 22";
            TestItem.StartedDate = DateTime.Now.Date;

            //set thisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //delete the record
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);

            //test to see that the record was not found
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();

            //apply a blank string (should return all records);
            FilteredStaff.ReportByName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredStaff.Count);

        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //apply a name that doesn't exist
            FilteredStaff.ReportByName("xxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesn't exist
            FilteredStaff.ReportByName("yyyy");

            //check that the correct number of records are found
            if (FilteredStaff.Count == 2)
            {
                //check that the first record is ID 36
                if (FilteredStaff.StaffList[0].StaffId != 50)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if(FilteredStaff.StaffList[1].StaffId != 51)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }



    }
}
