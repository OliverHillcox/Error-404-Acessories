using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing2
{
    [TestClass]
    public class tstStock
    {

        //good test data
        string itemid = "4";
        string itemname = "LogitechM535";
        string itemprice = "35.99";
        string itemquantity = "4";
        string itemover18 = "false";
        string itemdateadded = DateTime.Now.Date.ToString();

        [TestClass]
        public class tstStockCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                clsStockCollection AllStock = new clsStockCollection();
                Assert.IsNotNull(AllStock);
            }

            [TestMethod]
            public void StockListOK()
            {
                clsStockCollection AllStock = new clsStockCollection();
                List<clsStock> TestList = new List<clsStock>();
                clsStock TestItem = new clsStock();
                TestItem.ItemID = 5;
                TestItem.ItemName = "LogitechM355";
                TestItem.ItemOver18 = false;
                TestItem.ItemPrice = 35.00;
                TestItem.ItemQuantity = 12;
                TestItem.ItemDateAdded = DateTime.Now.Date;
                TestList.Add(TestItem);
                AllStock.StockList = TestList;
                Assert.AreEqual(AllStock.StockList, TestList);
            }

            [TestMethod]
            public void ThisStockPropertyOK()
            {
                clsStockCollection AllStock = new clsStockCollection();
                clsStock TestItem = new clsStock();
                TestItem.ItemID = 5;
                TestItem.ItemName = "LogitechM355";
                TestItem.ItemOver18 = false;
                TestItem.ItemPrice = 35.00;
                TestItem.ItemQuantity = 12;
                TestItem.ItemDateAdded = DateTime.Now.Date;
                AllStock.ThisStock = TestItem;
                Assert.AreEqual(AllStock.ThisStock, TestItem);
            }

            [TestMethod]
            public void CountPropertyOK()
            {
                clsStockCollection AllStock = new clsStockCollection();
                Int32 StockCount = 0;
                AllStock.Count = StockCount;
                Assert.AreEqual(AllStock.Count, StockCount);
            }
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinBoundary()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "a";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "ab";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxMinusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "xybmednzkfmbwlefltbjwhtodhieoqefhttnjqaekoaxzfdtl";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxBoundary()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "xybmednzkfmbwlefltbjwhtodhieoqefhttnjqaekoaxzfdtla";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "xybmednzkfmbwlefltbjwhtodhieoqefhttnjqaekoaxzfdtlab";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "xybmednzkfmbwlefltbjwhtod";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameExtremeMax()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemname = "mafqupcccjzlavqqendztsobhzojftssfnetkduveeykulqlyigvojzbirtaqvbvhbmncwpgfmqrpfegdnuqnzetmtbhwibjwzkrsvjcavjvgqatqzpbkwzjvrwuubiihxeotwxhvambhtmnmijhesaptplerwyiqyyrtekwgnapnpohppaybjretciykfacobivfujofujqaqqdjtwetawjjuxpqzmgiqediulyltrrcttizbkrbxctfmaxbydmydjjwcsubwklxkrgodivzyajbfaxfhgsyxdybabxroqo";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinLessOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinBoundary()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "0.01";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMinPlusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "1.01";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxMinusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "99998.99";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxBoundary()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "99999.99";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMaxPlusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "100000.99";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceMid()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "499.99";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceExtremeMax()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "999999999999.99";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPriceValidCheck()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemprice = "abcdefg";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityValidCheck()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemquantity = "abcdefg";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemOver18ValidCheck()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemover18 = "abcdefg";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateAddedValidCheck()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            string itemdateadded = "abcdefg";
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateAddedExtremeMin()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string itemdateadded = TestDate.ToString();
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateAddedMinLessOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string itemdateadded = TestDate.ToString();
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateAddedMin()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string itemdateadded = TestDate.ToString();
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateAddedMinPlusOne()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string itemdateadded = TestDate.ToString();
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateAddedExtremeMax()
        {
            clsStock someStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string itemdateadded = TestDate.ToString();
            Error = someStock.Valid(itemid, itemname, itemprice, itemquantity, itemover18, itemdateadded);
            Assert.AreNotEqual(Error, "");
        }

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

        [TestMethod]
        public void FindMethodOK()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemIDFound()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            if (someStock.ItemID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            if (someStock.ItemName != "CorsairK55")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemPriceFound()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            if (someStock.ItemPrice != Convert.ToDouble("64.99"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            if (someStock.ItemQuantity != 34)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemOver18Found()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            if (someStock.ItemOver18 != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemDateAddedFound()
        {
            clsStock someStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 itemid = 1;
            Found = someStock.Find(itemid);
            if (someStock.ItemDateAdded != Convert.ToDateTime("22/02/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
