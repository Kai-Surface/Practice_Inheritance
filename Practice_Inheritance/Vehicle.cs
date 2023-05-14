using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Vehicle
    {
        string _color;

        public Vehicle(string color)
        {
            Color = color;
        }

        public Vehicle(int wheels)
        {
            Wheels = wheels;
        }

        public string Color { get => _color; set => _color = value; }
        public int Wheels { get; }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
