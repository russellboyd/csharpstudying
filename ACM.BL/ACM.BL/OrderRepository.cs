using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderRepository
    {
        //Retrieve one order

        public Order Retrieve(int orderId)
        {
            //Create the instance of the Order class.  Pass in the requsted Id
            Order order = new Order(orderId);

            //Code that retrieves the defined order

            //Temporary hard coded values to return a populated order
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014,);
            }
            return order;
        }

        //Saves the current order.
        public bool Save()
        {
            //code that saves the defined order
            return true;
        }
    }
}
