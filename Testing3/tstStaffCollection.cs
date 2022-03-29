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



    }
}
