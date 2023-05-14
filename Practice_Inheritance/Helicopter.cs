using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Helicopter : Air
    {
        int _numberOfPropellers;

        public Helicopter(int numberOfPropellers)
        {
            NumberOfPropellers = numberOfPropellers;
        }

        public int NumberOfPropellers { get => _numberOfPropellers; set => _numberOfPropellers = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers{_numberOfPropellers}";
        }
    }
}
