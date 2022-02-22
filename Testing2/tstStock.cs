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
    }
}
