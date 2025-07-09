using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class Bike
    {
        public string model;
        public string color;
        public int year;

        public Bike(string modelName,string modelColor,int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }
}
