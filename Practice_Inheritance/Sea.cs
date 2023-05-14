using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Inheritance
{
    internal class Sea : Vehicle
    {
        enum Type { ship , boat , submarine , merchantShip }
        Type _type;

        private Type Type1 { get => _type; set => _type = value; }

        public Sea(Type type)
        {
            Type1 = type;
        }

        public override string ToString()
        {
            return base.ToString() + $" - It is a {_type}";
        }
    }
}
