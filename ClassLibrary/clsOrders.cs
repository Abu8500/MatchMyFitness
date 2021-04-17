using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public clsOrders()
        {
        }

        public int OrderId { get; set; }
        public bool Availability { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingInfo { get; set; }
    }
}