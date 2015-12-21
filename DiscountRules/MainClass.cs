using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Customer> cust = new List<Customer>
{
    new Customer(){ CustID = "Java", CustType="emp", MembershipSince=2, TotalBillAmount=101, GroceryBillAmount=23 },
    new Customer(){ CustID = "CSharp", CustType="aff", MembershipSince=3, TotalBillAmount=88, GroceryBillAmount=14 },
    new Customer(){ CustID = "CPlus", CustType="cust", MembershipSince=4, TotalBillAmount=257, GroceryBillAmount=123 },
    new Customer(){ CustID="SmallTalk", CustType="cust", MembershipSince=1, TotalBillAmount=100, GroceryBillAmount=12}
};
            RulesDiscountCalculator rl = new RulesDiscountCalculator();
            rl.CalculateNetPayableAmount(cust, rl);
            
            Console.ReadLine();
        }
    }
}
