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



    }
}
