using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Inputs();

            Operators op = new Operators();
            op.Arithmetic();
            op.Comparision();
            op.Assignment();
            op.Logical();

            InbuiltMethods im = new InbuiltMethods();
            im.Math();

            Details details = new Details();
            details.Detail();

            Demo d = new Demo();
            d.ShowCasting();

            DataTypes dt = new DataTypes();
            dt.Test();

            Words words = new Words();
            words.Convert();
            words.Operator();
            words.Concatation();
            words.Interpolation();
            words.Indexs();
            words.Letter();

            Test t = new Test();
            t.Check();
            t.Statements();
            t.Cases();
            t.Loops();
            t.Loops1();
            t.Loops2();

            Arrays arr = new Arrays();
            arr.Fruits();
            arr.Sorting();

            Car car = new Car();
            Console.WriteLine(car.Model);

            Bike b = new Bike("Mustang","Red",1969);
            Console.WriteLine(b.model + " " + b.color + " " + b.year);

            Methods methods = new Methods();
            methods.method1("Rekha");
            methods.method2("Prajakta", 23);
            methods.method3("Sweden");
            methods.method3();
            methods.method3("USA");

            Person p = new Person();
            p.Name = "Harshitha";
            Console.WriteLine(p.Name);

            Human h = new Human();
            h.Name = "Ganesh";
            Console.WriteLine(h.Name);

            Car1 car1 = new Car1();
            car1.honk();
            Console.WriteLine(car1.brand + " " + car1.modelName);

            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();
            animal.Sound();
            pig.Sound();
            dog.Sound();


            Bank bank = new SBI();
            bank.Display();
            bank.Interest();

            Circle circle = new Circle();
            circle.Draw();

            Day Today = Day.Wednesday;
            Console.WriteLine("Today is:" + Today);
            Console.WriteLine("Day Number is:" + (int)Today);

            Division.Divide(10, 2);
            Division.Divide(10, 0);


            /* Creating File */
            string path = "C:/Users/Sudha/Desktop/Demo.txt";
            File.WriteAllText(path, "Hello, this is new file");
            Console.WriteLine("File Created");

            /* Reading a File */
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("FIle Content:\n" + content);
            }
            else
            {
                Console.WriteLine("File does not exist");
            }



        }
    }   
}
