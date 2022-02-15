using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingCustomer
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCustomer clsCustomer = new clsCustomer();
            Assert.IsNotNull(clsCustomer);


        }
    }

}