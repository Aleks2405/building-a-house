using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Team : IWorker   // бригада строителей
    {
        private string a;
        Team[] team;

        public Team (string a)
        {
            this.a = a;

        }

        public override string ToString()
        {
            return $"{a}";
        }
    }
}
