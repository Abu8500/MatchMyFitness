using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrders
    {
        //good test data
        //create some test data to pass to the method
        string OrderDate = DateTime.Now.Date.ToString();
        string ShippingInfo = "test Shipping";



        [TestMethod]
        public void InstanceOK()
        {
            //created an instance of the class
            clsOrders AnOrder = new clsOrders();
            // test to make sure it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void AvailabilityOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Availability, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.OrderDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void ShippingInfoOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            string TestData = "Express Shipping (3 days)";
            //assign the data to the property
            AnOrder.ShippingInfo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShippingInfo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the results of validation
            Boolean Found = false;
            //create some test data
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is Ok (assuming it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //Invoke the method
            Found = AnOrder.Find(OrderId);
            //check the orderid
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);



        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.Availability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShippingInfoFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the property
            if (AnOrder.ShippingInfo != "test Shipping")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see that the results are correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin() //1
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //string variable to store error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the is less 100 then 100 years ago
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinLessone() //2
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //string variable to store error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the is less 100 then 100 years ago
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderDateMin() //3
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //string variable to store error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateMinPlusOne() //4
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //string variable to store error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date 
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateExtremeMax() //5
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //string variable to store error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date 
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string OrderDate = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateInvalidData() 
        {
            //create an instance of the class
            clsOrders AnOrder = new clsOrders();
            //string variable to store error messages
            String Error = "";
            //set the orderdate to a non date value
            string OrderDate = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void ShippingInfoMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShippingInfo = "aa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate,ShippingInfo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingInfoMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "a";
            //this should pass
            string ShippingInfo = "aaa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingInfoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingInfo = "aaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate,ShippingInfo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingInfoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingInfo = "aaaaaaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate,ShippingInfo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingInfoMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingInfo = "aaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate,ShippingInfo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingInfoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string ShippingInfo = "aaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate, ShippingInfo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingInfoMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string ShippingInfo = "aaaaaaa";
            //invoke the method
            Error = AnOrder.Valid(OrderDate,ShippingInfo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }












    }
}











    


