using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class SeaVehicle
    {
        //Field
        string _type;

        //Constructor
        public SeaVehicle(string color, string type)
        {
            _type = type;
        }

        //Property
        public string Type { get => _type; set => _type = value; }

        //Override ToString
        public override string ToString()
        {
            return base.ToString() + $"It is a {_type}";
        }
    }
}
