using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class ClothesCategoryStrategy : ICategoryStrategy
    {
        public decimal CalculatePrice()
        {
            return 10;
        }
    }
}