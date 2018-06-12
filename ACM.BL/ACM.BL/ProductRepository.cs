using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        //Retrieve one product

        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //Pass in the requested Id
            Product product = new Product(productId);
            Object myObject = new Object();
            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());
            //Code that retrieves the defined product

            //Temporary hard coded values to return a populated product

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        //Saves the current product
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges && product.IsvValid)
            {
                if (product.IsNew)
                {
                    //call an insert stored procedure
                }
                else
                {
                    //call an update stored procedure
                }
            }
            return success;
        }
    }
}
