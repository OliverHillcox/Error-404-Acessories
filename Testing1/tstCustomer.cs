using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void Over18OK()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean TestData = true;

            ACustomer.Active = TestData;

            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void BirthdayOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            DateTime TestData = DateTime.Now.Date;

            ACustomer.Birthday = TestData;

            Assert.AreEqual(ACustomer.Birthday, TestData);

        }

        [TestMethod]
        public void NameOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "";

            ACustomer.Name = TestData;

            Assert.AreEqual(ACustomer.Name, TestData);

        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "077486434568";

            ACustomer.PhoneNumber = TestData;

            Assert.AreEqual(ACustomer.PhoneNumber, TestData);

        }

        [TestMethod]
        public void EmailAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();

            String TestData = "ollie@gmail.com";

            ACustomer.EmailAddress = TestData;

            Assert.AreEqual(ACustomer.EmailAddress, TestData);

        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            ACustomer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.PostCode, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "18 Somerville Close";
            //assign the data to the property
            ACustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Address, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creating an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerID = 5;

            //invoke the method
            Found = ACustomer.Find(CustomerID);
            //test to see if the rsult is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.CustomerID != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBirthdayFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Birthday != Convert.ToDateTime("16/9/2000"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.Name != "Jason Morgue")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.PhoneNumber != "07866565645")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.EmailAddress != "beans@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPostCodeFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);

            if (ACustomer.PostCode.ToString() != "BS665KL")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();

            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 5;

            Found = ACustomer.Find(CustomerID);


            if (ACustomer.Address != "16 Lucky Lane")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        string name = "Jasone Morgue";
        string birthday = (new DateTime(2001, 10, 12)).ToString();
        string emailAddress = "memes@gmail.com";
        string address = "16 ridge road";
        string postcode = "LE30SS";
        string phoneNumber = "07866959543";
        string over18 = "true";

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string name = ""; //this should trigger an error
                              //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string name = "x";
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string name = "xx";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string name = "";
            name = name.PadRight(49, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string Nnameame = "";
            name = name.PadRight(50, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string name = "";
            name = name.PadRight(25, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string name = "";
            name = name.PadRight(51, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string name = "";
            name = name.PadRight(500, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");
        }




        //Birthday Test Methods



        [TestMethod]
        public void BirthdayExtreamMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store any error message
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //set the date to whatever the data is less 100 year
            TestDate = TestDate.AddYears(-101);
            //convert the date variable to a string variable
            string birthday = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BirthdayMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string birthday = TestDate.ToString();
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BirthdayMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string birthday = TestDate.ToString();
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void BirthdayExtreamMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string birthday = TestDate.ToString();
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void BirthdayInvalidDate()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            //set the Birthday to a non date value
            string birthday = "this is not a valid birthday";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");

        }



        //Test email Address

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";

            //this should fail
            string emailAddress = "";
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string emailAddress = "x";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string emailAddress = "xx";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(49, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(50, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(51, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string emailAddress = "";
            emailAddress = emailAddress.PadRight(25, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        // Test Address

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";

            //this should fail
            string address = "";
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string address = "a";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string address = "aa";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string address = "";
            address = address.PadRight(49, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string address = "";
            address = address.PadRight(50, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string address = "";
            address = address.PadRight(51, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string address = "";
            address = address.PadRight(25, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        //Test PostCode

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";

            //this should fail
            string postcode = "";
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string postcode = "xxxxxx";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string postcode = "xxxx xxxx";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string postcode = "";
            postcode = postcode.PadRight(10, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");
        }

        //Test Phone Number

        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";

            //this should fail
            string phoneNumber = "";
            //invoke the method
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumbeMin()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string phoneNumber = "a";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumbeMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string phoneNumber = "aa";
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumbeMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string phoneNumber = "";
            phoneNumber = phoneNumber.PadRight(49, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumberMax()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string phoneNumber = "";
            phoneNumber = phoneNumber.PadRight(50, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PhoneNumbeMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string phoneNumber = "";
            phoneNumber = phoneNumber.PadRight(51, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumbeMid()
        {
            clsCustomer ACustomer = new clsCustomer();

            String Error = "";
            string phoneNumber = "";
            phoneNumber = phoneNumber.PadRight(25, 'x');
            Error = ACustomer.Valid(name, birthday, emailAddress, address, postcode, phoneNumber, over18);
            Assert.AreEqual(Error, "");
        }



    }
}
