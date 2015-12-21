using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    interface IDiscountRule
    {
        double CalculateCustomerDiscount(Customer customer);
        
    }
}
