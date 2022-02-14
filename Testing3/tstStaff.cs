using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsStaff anStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(anStaff);
        }
    }
}
