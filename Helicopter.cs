using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class Helicopter : Vehicle
    {
        //Field
        int _NumberOfPropellers;

        //Constructor
        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            _NumberOfPropellers = numberOfPropellers;
        }

        //Property
        public int NumberOfPropellers { get => _NumberOfPropellers; set => _NumberOfPropellers = value; }

        // Override ToString
        public override string ToString()
        {
            return base.ToString() + $"Number of Propellers {_NumberOfPropellers}";
        }
    }
}
