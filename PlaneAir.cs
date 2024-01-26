using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class PlaneAir
    {
        int _numberOfJets;

        // Constructor
        public PlaneAir(string color, int numberOfJets)
        {
            _numberOfJets = numberOfJets;
        }

        // Property
        public int NumberOfJets { get => _numberOfJets; set => _numberOfJets = value; }

        //Override ToString
        public override string ToString()
        {
            return base.ToString() + $"Number of Jets {_numberOfJets}";
        }
    }
}
