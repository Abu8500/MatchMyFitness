using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomersCollection
    {
        [TestMethod]
        public void instanceOk()
        {
            //create an instance of the class we want to create
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomersListOK()
        {
            //create an instance of the class
            clsCustomersCollection AllCustomers = new clsCustomersCollection();
            //create some test data to assign to the property
            //list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();
            //add an item to the list
            //create item
            clsCustomers TestItem = new clsCustomers();
            //set properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Doe";
            TestItem.CreationDate = "01/01/2021";
            TestItem.Male = true;
            //add item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.customersList = TestList;
            //test to see the values are the same
            Assert.AreEqual(AllCustomers.customersList, TestList);
        }

       
    }
}
