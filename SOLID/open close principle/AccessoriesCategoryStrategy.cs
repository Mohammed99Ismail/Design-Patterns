using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    // this is extension for category calculator class and method, i wanted to Accessories Category so i extended this service
    public class AccessoriesCategoryStrategy : ICategoryStrategy
    {
        public decimal CalculatePrice()
        {
            return 5;
        }
    }
}