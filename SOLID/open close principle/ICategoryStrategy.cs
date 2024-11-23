using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    interface ICategoryStrategy
    {
        decimal CalculatePrice();
    }
}