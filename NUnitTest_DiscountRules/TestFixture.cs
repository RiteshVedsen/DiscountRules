using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using DiscountRules;

namespace NUnitTest_DiscountRules
{
    [TestFixture]
    public class TestFixture1
    {
        [TestCase]
        public void TestTrue()
        {
            EmployeeRule emprule = new EmployeeRule();
            Customer cust1 = new Customer { CustID = "Java", CustType = "emp", MembershipSince = 2, TotalBillAmount = 101, GroceryBillAmount = 23 };
            double DiscountPercentage1 = emprule.CalculateCustomerDiscount(cust1);
            Assert.AreEqual(0.3, DiscountPercentage1);
        }

         //This test fail for example, replace result or delete this test to see all tests pass
        [TestCase]
        public void TestFault()
        {
            Assert.IsTrue(true);
            Console.WriteLine("Test ran sucessfully");
            Console.ReadLine();
        }
    }
}
