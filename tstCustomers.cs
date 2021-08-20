using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomers
    {
        int CustomerID = 1;
        string FirstName = "John";
        string LastName = "Doe";
        DateTime CreationDate = "01/01/2021";
        bool Male = true;

        [TestMethod]
        public void InstanceOK()
        {
            //created an instance of the class
            clsCustomers customer = new clsCustomers();
            // test to make sure it exists
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class we want to create
            clsCustomers customer = new clsCustomers();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            customer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(customer.CustomerID, TestData);
        }
    }
}
