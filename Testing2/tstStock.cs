using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;


namespace Testing2
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock SomeStock = new clsStock();
            Assert.IsNotNull(SomeStock);
        }

        [TestMethod]
        public void ItemNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data
            String TestData = "CorsairK55";
            //assign the data to the property
            SomeStock.ItemName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(SomeStock.ItemName, TestData);
        }

        [TestMethod]
        public void ItemQuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data
            int TestData = 34;
            //assign the data to the property
            SomeStock.ItemQuantity = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(SomeStock.ItemQuantity, TestData);
        }

        [TestMethod]
        public void ItemPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data
            double TestData = 64.99;
            //assign the data to the property
            SomeStock.ItemPrice = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(SomeStock.ItemPrice, TestData);
        }

        [TestMethod]
        public void ItemIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data
            int TestData = 1;
            //assign the data to the property
            SomeStock.ItemID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(SomeStock.ItemID, TestData);
        }

        [TestMethod]
        public void ItemOver18PropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data
            bool TestData = true;
            //assign the data to the property
            SomeStock.ItemOver18 = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(SomeStock.ItemOver18, TestData);
        }

        [TestMethod]
        public void ItemDateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock SomeStock = new clsStock();
            //create some test data
            DateTime TestData = new DateTime(2022, 2, 22);
            //assign the data to the property
            SomeStock.ItemDateAdded = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(SomeStock.ItemDateAdded, TestData);
        }
    }
}
