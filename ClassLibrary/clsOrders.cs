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

        public bool Find(int ordersId)
        {
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