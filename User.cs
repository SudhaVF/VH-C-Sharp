using System;

namespace Programs
{
    internal class User
    {
        public void Inputs()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            Console.Write("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age);
        }
    }
}