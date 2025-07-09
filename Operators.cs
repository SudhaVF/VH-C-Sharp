using System;

namespace Programs
{
    internal class Operators
    {

        public void Arithmetic()
        {

            int a = 15;
            int b = 20;
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Substraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));
            Console.WriteLine("Increment: " + (a++));
            Console.WriteLine("Decrement: " + (a--));
        }
        public void Assignment()
        {
            int x = 10;
            Console.WriteLine(x);

            x += 10;
            Console.WriteLine(x);

            x -= 2;
            Console.WriteLine(x);

            x *= 3;
            Console.WriteLine(x);

            x /= 4;
            Console.WriteLine(x);

            x %= 3;
            Console.WriteLine(x);


        }
        public void Comparision()
        {
            int a = 15;
            int b = 20;

            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

        }
        public void Logical()
        {

            int x = 8;
            int y = 3;
            Console.WriteLine(x > 5 && y < 10);
            Console.WriteLine(x > 10 || y < 5);
            Console.WriteLine(!(x < 10));

        }


    }
}