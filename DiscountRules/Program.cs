using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    public class RulesDiscountCalculator: IDiscountCalculator
    {
        List<IDiscountRule> DiscountPercentagerules = new List<IDiscountRule>();
        List<IDiscountRule> Discountrules = new List<IDiscountRule>();
        public RulesDiscountCalculator()
        {
            DiscountPercentagerules.Add(new LoyalCustomerRule());
            DiscountPercentagerules.Add(new EmployeeRule());
            DiscountPercentagerules.Add(new AffiliateRule());
            Discountrules.Add(new DiscountOnBills());
         }
        public double CalculateDiscountPercentage(Customer customer)
        {            
            double discount = 0;
            foreach (var rule in DiscountPercentagerules)
            {
                discount = Math.Max(rule.CalculateCustomerDiscount(customer), discount);
            }
            return discount;
        }
        public double CalculateDiscount(Customer customer)
        {
            double discount=0;
            foreach (var rule in Discountrules)
            {
                discount = rule.CalculateCustomerDiscount(customer);
            }
            return discount;
        }
        public void CalculateNetPayableAmount(List<Customer> cust, RulesDiscountCalculator rl)
        {
            double discountpercentage;
            double discount;
            double NetPayableAmount;
            for (int i = 0; i < cust.Count; i++)
            {
                discountpercentage = rl.CalculateDiscountPercentage(cust[i]);
                discount = rl.CalculateDiscount(cust[i]);
                NetPayableAmount = (cust[i].TotalBillAmount) - discount - (cust[i].TotalBillAmount - cust[i].GroceryBillAmount) * discountpercentage;
                Console.WriteLine("The net Payable amount for Customer: {0} is {1}", cust[i].CustID, NetPayableAmount);
              
            }
            
        }
    }
    
}
