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
        public void InternPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            anStaff.Intern = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(anStaff.Intern, TestData);
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

        [TestMethod]
        public void PhonePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff anStaff = new clsStaff();
            //create some testdata to assign to the property
            String TestData = "078 3965 3462";
            //assign the data to the property
            anStaff.Phone = TestData;
            //test to see that two values are the same
            Assert.AreEqual(anStaff.Phone, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creating an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 2;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the rsult is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to store the rsult of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStartedDateFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to sore the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StartedDate != Convert.ToDateTime("13/04/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInternFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to sore the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Intern != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to sore the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Name != "john")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to sore the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Address != "XX XXX XXXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to sore the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Salary != 20000.00)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneFound()
        {
            //create an instance of class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to sore the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK(assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 3;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.Phone != "123 456 7890")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
