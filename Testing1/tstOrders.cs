using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK() {
            //created an instance of the class
            clsOrders AnOrder = new clsOrders();
            // test to make sure it exists
            Assert.IsNotNull(AnOrder);
        }



        





        }
    }

