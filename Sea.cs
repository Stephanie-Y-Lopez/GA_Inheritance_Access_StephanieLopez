using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class Sea : Vehicle
    {
        //Field
        string _type;

        //Constructor
        public Sea(string color, string type) : base(color)
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
