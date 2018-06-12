using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //constructor chaining
        public Customer() : this(0)
        { }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        public static int InstanceCount { get; set; }

        private string _lastname;

        public string LastName
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public Customer Retrieve(int customerId)
        {
            //Code that retrieves the defined customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            //code that saves the defined customer
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (String.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;  
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
