using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{

    class DiscountOnBills : IDiscountRule
    {
        public double CalculateCustomerDiscount(Customer customer)
        {
            return  (customer.TotalBillAmount) >=100 ? (int)(customer.TotalBillAmount/100)*5.0 : 0.0;
        }
        
    }
}
