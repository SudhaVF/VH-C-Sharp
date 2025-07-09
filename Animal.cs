using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /* Polymorphism */
    /* if we add virtual keyword in Base class and override keyword in Derived class,then the output will be from all the class */
    internal class Animal
    {
        public void Sound()
        {
            Console.WriteLine("The Animal makes a Sound");
        }
    }
    class Pig : Animal
    {
        public void Sound()
        {
            Console.WriteLine("The Pig Says: wee wee");
        }
    }
    class Dog : Animal
    {
        public void Sound()
        {
            Console.WriteLine("The Dog Says: bow bow");
        }
    }
}
