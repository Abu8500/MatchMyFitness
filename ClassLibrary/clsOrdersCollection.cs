using System.Collections.Generic;
using System;


namespace ClassLibrary
{
    public class clsOrdersCollection
    {

        //private data memeber for list
        List<clsOrders> mOrderList = new List<clsOrders>();
        //set properties

       
            
        public List<clsOrders> OrderList {

            get
            {
                //return private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }


        }
        public int Count {

            get
            {
                //return Count of list
                return mOrderList.Count;

            }
            set
            {
                //do this later
            }





        }

        public clsOrders ThisOrder { get; set; }

        public clsOrdersCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0
            //object for the data connection
            clsOrdersCollection DB = new clsOrdersCollection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");


        }
      

    }
}