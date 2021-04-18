using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for the Orderid property
        private Int32 mOrderId;
        private Boolean mAvailability;
        private DateTime mOrderDate;
        private String mShippingInfo;




        public clsOrders()
        {
        }

        public Int32 OrderId {

            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;


            }
           }
        public bool Availability {

            get
            {
                //return the private data
                return mAvailability;
            }
            set
            {
                //set the private data
                mAvailability = value;
            }
             }
        public DateTime OrderDate {

            get
            {
                //return the private data
                return mOrderDate;

            }
            set
            {
                //set the private data
                mOrderDate = value;
            }






        }
        public string ShippingInfo {
            get
            {
                //return the private data
                return mShippingInfo;
            }
            set
            {
                //set the private data
                mShippingInfo = value; 
            }


            }

        public bool Find(int OrderId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the orderid to search
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FIlterByOrderId");
            //if one record is found (there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mShippingInfo = Convert.ToString(DB.DataTable.Rows[0]["ShippingInfo"]);

            }







            //set the private data member to the test data value
            mOrderId = 1;
            mAvailability = true; 
            mOrderDate = Convert.ToDateTime("16/9/2015");
            mShippingInfo = "test Shipping"; 
            //return true
            return true;
        }
    }
}