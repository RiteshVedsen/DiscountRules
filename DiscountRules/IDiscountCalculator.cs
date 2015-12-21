using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscountRules
{
    public interface IDiscountCalculator
    {
        double CalculateDiscountPercentage(Customer customer);
        double CalculateDiscount(Customer customer);
    }
}
