using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public interface ICar
    {
        void GetCarType();
    }

    public class Car
    {
        public string Name { get; set; }
    }

    public class BMW : Car, ICar
    {
        public void GetCarType()
        {
            Console.WriteLine("BMW");
        }
    }
}