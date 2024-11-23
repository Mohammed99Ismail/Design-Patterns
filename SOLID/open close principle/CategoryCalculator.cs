using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class CategoryCalculator
    {
        private ICategoryStrategy category;
        public CategoryCalculator(ICategoryStrategy category)
        {
            this.category = category;
        }

        public decimal CalculateCategory()
        {
            return category.CalculatePrice();
        }
    }
}