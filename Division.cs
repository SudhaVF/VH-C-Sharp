using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Division
    {
        public static void Divide(int a,int b)
        {
            try
            {
                int result = a / b;
                Console.WriteLine("Result:" + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide by zero");
            }
        }
    }
}
