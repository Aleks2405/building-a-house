using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Team    // бригада строителей
    {
        Worker Work = new Worker();
        TeamLeader teamleader = new TeamLeader();
        
        public Team(int value)
        {
            IPart[] asaa = {
                new Basement(),
                new Walls(),
               new Window(),
                new Door(),
                new Part()

            };

            foreach (IPart asa in asaa)
            {

                Console.WriteLine(asa.ToString());
            }
        }
        
       
      
    }
}
