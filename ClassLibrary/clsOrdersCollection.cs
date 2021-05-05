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
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank order
                clsOrders AnOrder = new clsOrders();
                //read in the fields
                AnOrder.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                AnOrder.ShippingInfo = Convert.ToString(DB.DataTable.Rows[Index]["Shippinginfo"]);
                AnOrder.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //print at the next record
                Index++;
                


            }

        }
      

    }
}