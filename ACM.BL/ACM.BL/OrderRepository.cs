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

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            //Code that retrieves the defined order fields
            if (orderId == 10)
            {
                orderDisplay.FirstName = "Bilbo";
                orderDisplay.LastName = "Baggins";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan);
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                };
            }

            orderDisplay.orderDisplayItemList = new List<OrderDisplayItem>();

            //Code that retrieves the order items

            //Temporary Hard-coded data
            if (orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Sunflowers",
                    PurchasePrice = 15.96M,
                    OrderQuantity = 2
                };
                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "Rake",
                    PurchasePrice = 6M,
                    OrderQuantity = 1
                };

                orderDisplay.orderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        //Saves the current order.


    }
}
