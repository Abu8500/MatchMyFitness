using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void instanceOk()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);

        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create item
            clsOrders TestItem = new clsOrders();
            //set properties
            TestItem.Availability = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShippingInfo = "test Shipping";
            //add item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see the values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);


        }

        

        [TestMethod]
        public void ThisOrderOK()
        {
            //create an instance
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //creating test data
            clsOrders TestOrder = new clsOrders();
            //set the properties
            TestOrder.Availability = true;
            TestOrder.OrderId = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.ShippingInfo = "test shipping";
            //assign te data
            AllOrders.ThisOrder = TestOrder;
            //test to see values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

           }
        [TestMethod]

        public void ListandCountOK()
        {
            //create an instance
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create test data
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item
            clsOrders TestItem = new clsOrders();
            //setting properties
            TestItem.Availability = true;
            TestItem.OrderId = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ShippingInfo = "test shipping";
            //add the items to list
            TestList.Add(TestItem);
            //assign data to property
            AllOrders.OrderList = TestList;
            //test to see the values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
        



    }
}
