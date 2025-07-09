using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /* Abstraction */
    abstract class Bank
    {
        public abstract void Interest();
        public void Display()
        {
            Console.WriteLine("Welcome to the Bank!");
        }

    }
    class SBI : Bank
    {
        public override void Interest()
        {
            Console.WriteLine("SBI Interest: 6.5% per annum");
        }
    }

    class HDFC : Bank
    {
        public override void Interest()
        {
            Console.WriteLine("HDFC Interest : 7.0% per annum");
           
        }
    }

}
