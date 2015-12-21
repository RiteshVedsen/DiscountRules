using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    public class EmployeeRule : IDiscountRule
    {
       
        public double CalculateCustomerDiscount(Customer customer)
        {
          return (customer.CustType=="emp") ? 0.30 : 0.0;
        }
        
    }
}
