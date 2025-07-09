using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    /* Interface */
    interface Shape
    {
        void Draw();

    }
    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }
    class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Draw a Square");
        }
    }
}
