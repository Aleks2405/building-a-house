using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Door : IPart
    {
        public string Name { get; } = " DOOR";

        public override string ToString()
        {
            return base.ToString() + $"{ Name}";
        }
    }
}
