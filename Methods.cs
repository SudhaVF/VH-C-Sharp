using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Methods
    {
        public  void method1(string name)
        {
            Console.WriteLine(name);
        }
        public void method2(string name,int age)
        {
            Console.WriteLine(name + " is " + age);
        }
        public void method3(string country = "India")
        {
            Console.WriteLine(country);
        }

       
    }
}
