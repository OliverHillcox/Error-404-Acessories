using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        //create some test data to pass to the method
        string Name = "John";
        string StartedDate = DateTime.Now.Date.ToString();
        string Address = "3  Abington Park,Leicester,United Kingdom";
        string Salary = "23000";
        string Phone = "079 4975 1422 ";


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
            Int32 StaffId = 3;
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
            if (AnStaff.StartedDate != Convert.ToDateTime("2019/12/08"))
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
            if (AnStaff.Intern != false)
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
            if (AnStaff.Name != "Matthew")
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
            if (AnStaff.Address != "3  Abington Park,Leicester,United Kingdom")
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
            if (AnStaff.Salary != 23000)
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
            if (AnStaff.Phone != "079 4975 1422 ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStaff.Valid(Name,StartedDate,Address,Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = ""; 
            //create some test data to pass to the method
            string Name = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Name = "aa";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Name = "";
            Name = Name.PadRight(49, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Name = "";
            Name = Name.PadRight(50, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Name = "";
            Name = Name.PadRight(25, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Name = "";
            Name = Name.PadRight(51, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartedDateExtreamMin()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create a variable to store any error message
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //set the date to whatever the data is less 100 year
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string StartedDate = TestDate.ToString();
            //invoke the method
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartedDateMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string StartedDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartedDateMin()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StartedDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartedDateMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string StartedDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StartedDateExtreamMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StartedDate = TestDate.ToString();
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void StartedDateInvalidDate()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            //set the StartedDate to a non date value
            string StartedDate = "this is not a date";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";

            //this should fail
            string Address = "";
            //invoke the method
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Address = "a";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Address = "aa";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Address = "";
            Address = Address.PadRight(49, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Address = "";
            Address = Address.PadRight(50, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Address = "";
            Address = Address.PadRight(51, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Address = "";
            Address = Address.PadRight(25, 'a');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMin()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "1";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "01";
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "";
            Phone = Phone.PadRight(49, '0');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMax()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "";
            Phone = Phone.PadRight(50, '1');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "";
            Phone = Phone.PadRight(51, '1');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMid()
        {
            clsStaff AnStaff = new clsStaff();

            String Error = "";
            string Phone = "";
            Phone = Phone.PadRight(25, '1');
            Error = AnStaff.Valid(Name, StartedDate, Address, Phone);
            Assert.AreEqual(Error, "");
        }

    }
}
