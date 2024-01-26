using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class HelicopterAir
    {
        //Field
        int _NumberOfPropellers;

        //Constructor
        public HelicopterAir(string color, int numberOfPropellers)
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
