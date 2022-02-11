using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Worker : IWorker
    {
        public void Work(IPart part);

        public int quant { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{}";
        }

    }
}
