using System;

namespace Programs
{
    internal class InbuiltMethods
    {
        public void Math()
        {
            double x = 5.2;
            int y = 6;
            Console.WriteLine(System.Math.Max(x, y));
            Console.WriteLine(System.Math.Min(x, y));
            Console.WriteLine(System.Math.Sqrt(y));
            Console.WriteLine(System.Math.Abs(x));
            Console.WriteLine(System.Math.Round(x));
        }

    }
}