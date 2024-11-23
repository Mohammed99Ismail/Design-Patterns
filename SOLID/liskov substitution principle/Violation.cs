using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internal;

namespace LiskovSubstitutionPrinciple_Violation
{
    public class Car
    {
        public virtual void GetCarType()
        {
            Console.WriteLine("Car");
        }
    }

    public class BMW : Car
    {
        public override void GetCarType()
        {
            Console.WriteLine("BMW");
        }
    }
}