using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some tst data to pass to the method

        string DateofPurchase = DateTime.Now.Date.ToString();
        string Address = "109 Hollywood Avenue, Birmingham, B35 4HE";
        int OrderQnty = 2;
        Double OrderPrice = 150.00;

        [TestMethod]
        public void DispatchedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Dispatched = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnOrder.Dispatched, TestData);
        }

        [TestMethod]
        public void DateofPurchasePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to property
            AnOrder.DateofPurchase = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateofPurchase, TestData);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "109 Hollywood Avenue, Birmingham, B35 4HE";
            //assign the data to the property
            AnOrder.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Address, TestData);
        }
        [TestMethod]
        public void OrderPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Double TestData = 1500.00;
            //assign the data to the property
            AnOrder.OrderPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderPrice, TestData);
        }

        [TestMethod]
        public void OrderQntyPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 20;
            //assign the data to the property
            AnOrder.OrderQnty = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderQnty, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 675;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            // Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the order no
            if (AnOrder.OrderNo != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderQntyFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderQnty != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestOrderPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderPrice != 70.22)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDispatchedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Dispatched != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDateofPurchaseFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.DateofPurchase != Convert.ToDateTime("05/05/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 5;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Address != "1357 Blane Street, Saint Louis, MO 63101")
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
            clsOrder AnOrder = new clsOrder();
            //string varaible to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "b";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "bb";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // this should fail
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = "";
            Address = Address.PadRight(500, 'a'); // this should fail
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateofPurchaseExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
           String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
             //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateofPurchase = TestDate.ToString();
            //invoke the method
           Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateofPurchaseMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            // change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            String DateofPurchase = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateofPurchaseMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateofPurchase = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateofPurchaseMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string vairable
            string DateAdded = TestDate.ToString();
            //convert the date variable to a string variable
            string DateofPurchase = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateofPurchaseExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //DATE IS PLUS 100 YEARS
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string vairable
            string DateofPurchase = TestDate.ToString();        
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateofPurchaseInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //set the DateofPurchase to a non date value
            string DateofPurchase = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
           
        }

        [TestMethod]
        public void OrderQntyExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = -2147483648;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = -1;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 0;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 1;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 99;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 100;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 101;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderQntyMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 50;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderQntyExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int OrderQnty = 2147483647;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = Double.MinValue;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = -1.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 0.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 1.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 9999.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 10000.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 10001.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = 5000.00;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderPriceExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double OrderPrice = Double.MaxValue;
            Error = AnOrder.Valid(Address, DateofPurchase, OrderQnty, OrderPrice);
            Assert.AreNotEqual(Error, "");

       }
    }
}



