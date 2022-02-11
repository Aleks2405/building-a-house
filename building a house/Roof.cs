﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Roof : IPart
    {
        public string Name { get; } = "Roof";

        public override string ToString()
        {
            return base.ToString() + $"{Name}";
        }
    }
}
