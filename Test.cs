using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Test
    {
        public void Check()
        {
            int myAge = 22;
            int votingAge = 18;
            Console.WriteLine(myAge >= votingAge);
        }

        /* if-else if- else Statement */
        public void Statements()
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        /*Switch Statement */
        public void Cases()
        {
            Console.Write("Enter a number (1 to 7): ");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                    break;
            }
        }

        /* For Loop */
        public void Loops()
        {
            Console.WriteLine("Even numbers from 1 to 10:");

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /* While Loop */
        public void Loops1()
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        /* Do-While Loop */
        public void Loops2()
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Say Bye");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;
                    case 2:
                        Console.WriteLine("Bye!");
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 3);

        }



    }
}
