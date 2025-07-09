using System;

namespace Programs
{
    internal class Words
    {
        /* Conversion of string to lower case and upper case */
        public void Convert()
        {
            string txt = "Hello World";
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt.ToUpper());
        }

        /* Concatation of two strings */
        public void Operator()
        {
            string firstName = "Sudha";
            string lastName = "Fadi";
            string name = firstName + lastName;
            Console.WriteLine(name);

        }

        /* Concatation of two string using method */
        public void Concatation()
        {
            string name1 = "Sudha";
            string name2 = "Fadi";
            string str = string.Concat(name1, name2);
            Console.WriteLine(str);
        }

        /*Interpolation of string */
        public void Interpolation()
        {
            string fname = "Rekha";
            string lname = "G";
            string name = $"My full name is:{fname},{lname}";
            Console.WriteLine(name);
        }

        /* print letter in string */
        public void Indexs()
        {
            string myString = "Hello";
            Console.WriteLine(myString[1]);
        }

        /* print index of the letter */
        public void Letter()
        {
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("o"));
        }
    }
}