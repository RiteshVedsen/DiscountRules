using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    public class LoyalCustomerRule:IDiscountRule
    {
        public double CalculateCustomerDiscount(Customer customer)
        {
            return (customer.MembershipSince >= 2) ? 0.05 : 0.0;
        }

    }
}
