using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class Plane : Vehicle
    {
        int _numberOfJets;

        // Constructor
        public Plane(string color, int numberOfJets) : base(color)
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
