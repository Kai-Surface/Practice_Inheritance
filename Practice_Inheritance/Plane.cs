using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Plane : Air
    {
        int _numberOfJets;

        public Plane(int numberOfJets)
        {
            NumberOfJets = numberOfJets;
        }

        public int NumberOfJets { get => _numberOfJets; set => _numberOfJets = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets {_numberOfJets}";
        }
    }
}
