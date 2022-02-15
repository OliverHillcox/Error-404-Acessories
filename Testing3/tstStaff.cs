using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsStaff anStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(anStaff);
        }

        [TestMethod]
        public void InterenPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            anStaff.Interen = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(anStaff.Interen, TestData);
        }

        [TestMethod]
        public void StartedDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some test data to assaign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            anStaff.StartedDate = TestData;
            //test to see that two values are the same
            Assert.AreEqual(anStaff.StartedDate, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaff anStaff = new clsStaff();
            //create some testdata to assign to the property
            int TestData = 1;
            //assign the data to the property
            anStaff.StaffId = TestData;
            //test to see that two values are the same
            Assert.AreEqual(anStaff.StaffId, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some testdata to assign to the property
            String TestData = "John";
            //assign the data to the property
            anStaff.Name = TestData;
            //test to see that two values are the same
            Assert.AreEqual(anStaff.Name, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some testdata to assign to the property
            String TestData = "14 Mashall close, Leicester, United Kingdom";
            //assign the data to the property
            anStaff.Address = TestData;
            //test to see that two values are the same
            Assert.AreEqual(anStaff.Address, TestData);
        }

        [TestMethod]
        public void SalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some testdata to assign to the property
            Double TestData = 20000.00;
            //assign the data to the property
            anStaff.Salary = TestData;
            //test to see that two values are the same
            Assert.AreEqual(anStaff.Salary, TestData);
        }


    }
}
