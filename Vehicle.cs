using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class Vehicle
    {
        //Field
        string _color;

        //Constructor
        public Vehicle(string color)
        {
            _color = color;
        }

        //Property
        public string Color1 { get => _color; set => _color = value; }

        //Override ToString
        public override string ToString()
        {
            return $"{this.GetType().Name} - {_color}";
        }

    }
}
