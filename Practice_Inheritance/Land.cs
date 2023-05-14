using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Land : Vehicle
    {
        int _wheels;

        public Land(int wheels, string color) : base(wheels, color)
        {
            this.Wheels = _wheels;
        }



        public int Wheels { get => _wheels; set => _wheels = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels {_wheels} ";
        }
    }
}
