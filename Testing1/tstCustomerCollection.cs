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
    }
}
