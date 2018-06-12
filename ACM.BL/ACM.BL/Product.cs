using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase 
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }
        private String _ProductName;

        public String ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        //Retrieve one product.

        public Product Retrieve(int productId)
        {
            //Code that retrieves the defined product
            return new Product();
        }

        //Saves the current product.
        public bool Save()
        {
            //Code that saves the defined product
            return true;
        }

        //Validates the product data
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = true;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string InsertSpaces()
        {
            var source = ProductName;
        }
    }
}
