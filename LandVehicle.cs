using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class LandVehicle
    {
        //Field
        int _wheels;

        public LandVehicle(string color, int wheels)
        {
            _wheels = wheels;
        }

        //Property}
        public int Wheels1 { get => _wheels; set => _wheels = value; }

        //Override ToString
        public override string ToString()
        {
            return base.ToString() + $"Number of Wheels {_wheels}";
        }
    }
}
