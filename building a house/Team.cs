using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Team    // бригада строителей
    {
        Worker Worke = new Worker();
        TeamLeader teamleader = new TeamLeader();

        public Team(int value)
        {
            IPart[] teamLeader =
            {
            new Basement(),
            new Window()
        };
        }
        
       
      
    }
}
