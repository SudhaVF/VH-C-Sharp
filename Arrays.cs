using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Arrays
    {

        /* print all data in the array */
        public void Fruits()
        {
            string[] fruits = { "Apple", "Banana", "Mango", "Orange" };

            Console.WriteLine("Fruits in the array:");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }

        /* Sort the array */
        public void Sorting()
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Toyota" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
