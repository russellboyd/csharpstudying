using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        //retrieve one order.
        public Order Retrieve(int orderId)
        {
            //Code that retrieves the defined order
            return new Order();
        }

        //Saves the current order
        public bool Save()
        {
            //Code that saves the defined order
            return true;
        }

        //Validates the order data.
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }


        
    }
}
