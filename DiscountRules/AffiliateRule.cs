using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    class AffiliateRule : IDiscountRule
    {
        public double CalculateCustomerDiscount(Customer customer)
        {
            return (customer.CustType == "aff") ? 0.10 : 0.0;
        }
        
    }
}
