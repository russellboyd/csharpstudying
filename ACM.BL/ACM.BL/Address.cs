using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        //default constructor
        public Address()
        { }

        //constructor that takes primary key ID as a parameter
        public Address(int addressId)
        {
            this.AddressId = addressId;
        }

        //properties
        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }


    }
}
