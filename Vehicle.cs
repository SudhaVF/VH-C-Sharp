using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /* Inheritance */
    internal class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut,tuut!");
        }
    }
    class Car1 : Vehicle
    {
        public string modelName = "Mustang";

    }
}
