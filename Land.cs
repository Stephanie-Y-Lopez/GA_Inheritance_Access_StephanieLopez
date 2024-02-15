using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class Land : Vehicle
    {
        //Field
        int _wheels;

        public Land(string color, int wheels) : base(color)
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
