using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {




        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.Name = "Oliver H";
            TestItem.Birthday = new DateTime(2001, 10, 1);
            TestItem.PostCode = "le2110";
            TestItem.PhoneNumber = "07654332115";
            TestItem.EmailAddress = "Ollie@gmail.com";
            TestItem.Address = "17 Lucky Lane";

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Active = true;
            TestCustomer.Name = "Oliver H";
            TestCustomer.Birthday = new DateTime(2001, 10, 1);
            TestCustomer.PostCode = "le2110";
            TestCustomer.PhoneNumber = "07654332115";
            TestCustomer.EmailAddress = "Ollie@gmail.com";
            TestCustomer.Address = "17 Lucky Lane";


            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }


        [TestMethod]
        public void ListAndCountPropertyOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Active = true;
            TestCustomer.Name = "Oliver H";
            TestCustomer.Birthday = new DateTime(2001, 10, 1);
            TestCustomer.PostCode = "le2110";
            TestCustomer.PhoneNumber = "07654332115";
            TestCustomer.EmailAddress = "Ollie@gmail.com";
            TestCustomer.Address = "17 Lucky Lane";

            TestList.Add(TestCustomer);

            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;

            //set its property
            TestItem.Active = true;
            TestItem.Name = "Oliver H";
            TestItem.Birthday = new DateTime(2001, 10, 1);
            TestItem.PostCode = "le2110";
            TestItem.PhoneNumber = "07654332115";
            TestItem.EmailAddress = "Ollie@gmail.com";
            TestItem.Address = "17 Lucky Lane";

            //set thisstaff to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.Active = true;
            TestItem.Name = "Oliver H";
            TestItem.Birthday = new DateTime(2001, 10, 1);
            TestItem.PostCode = "le2110";
            TestItem.PhoneNumber = "07654332115";
            TestItem.EmailAddress = "Ollie@gmail.com";
            TestItem.Address = "17 Lucky Lane";

            //set thisstaff to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;

            TestItem.Active = false;
            TestItem.Name = "Oliver kappa";
            TestItem.Birthday = new DateTime(2000, 11, 1);
            TestItem.PostCode = "le2110";
            TestItem.PhoneNumber = "07654662115";
            TestItem.EmailAddress = "Ollie@yahoo.com";
            TestItem.Address = "15 Lucky Lane";
            //find the record
            AllCustomers.ThisCustomer = TestItem;

            AllCustomers.Update();

            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.Active = true;
            TestItem.Name = "Oliver H";
            TestItem.Birthday = new DateTime(2001, 10, 1);
            TestItem.PostCode = "le2110";
            TestItem.PhoneNumber = "07654332115";
            TestItem.EmailAddress = "Ollie@gmail.com";
            TestItem.Address = "17 Lucky Lane";

            //set thisstaff to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;

            AllCustomers.ThisCustomer.Find(PrimaryKey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomerCollection FilterdCustomers = new clsCustomerCollection();

            FilterdCustomers.ReportByPostCode("");

            Assert.AreEqual(AllCustomers.Count, FilterdCustomers.Count);

        }


        [TestMethod]
        public void ReportByPostCodeNoneFound()
        {
            clsCustomerCollection FilterdCustomers = new clsCustomerCollection();

            FilterdCustomers.ReportByPostCode("xxx xxx");

            Assert.AreEqual(0, FilterdCustomers.Count);
        }

        [TestMethod]
        public void ReportByPostCodeTestDataFound()
        {
            clsCustomerCollection FilterdCustomers = new clsCustomerCollection();

            Boolean OK = true;

            FilterdCustomers.ReportByPostCode("yyy yyy");

            if (FilterdCustomers.Count == 2)
            {
                if (FilterdCustomers.CustomerList[0].CustomerID != 0)
                    OK = false;
                if (FilterdCustomers.CustomerList[1].CustomerID != 1)
                    OK = false;
            }
            else
                OK = false;

            OK = true;

            Assert.IsTrue(OK);
        }


    }
}
