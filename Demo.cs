using System;

namespace Programs
{
    internal class Demo
    {
        public void ShowCasting()
        {
            //Explicit Type Casting
            double d = 123.45;
            int num = (int)d;
            Console.WriteLine("TypeCasting from double to int:" + num);



            //Implicit Type Casting
            int x = 10;
            double y = x;
            Console.WriteLine("TypeCasting from int to double:" + y);


        }

    }
}