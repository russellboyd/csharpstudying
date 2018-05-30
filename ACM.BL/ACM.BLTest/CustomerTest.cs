using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
		//Arrange
		Customer customer = new Customer();
		customer.FirstName = "Bilbo";
		customer.LastName = "Baggins";

		string expected = "Baggins, Bilbo";

		//Act
		string actual = customer.FullName;

		//Assert
		Assert.AreEqual(expected, actual);
        }
    }
}
