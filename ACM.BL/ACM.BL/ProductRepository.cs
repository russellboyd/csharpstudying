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

            //Code that retrieves the defined product

            //Temporary hard coded values to return a populated product

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.96M;

            }
        }
    }
}
