﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class Team    
    {
        Worker Work = new Worker();
        
        TeamLeader teamleader = new TeamLeader();
        
        public Team()
        {
            IPart[] asaa = {
                new Basement(),
                new Walls(),
               new Walls(),
               new Walls(),
               new Walls(),
               new Door(),
               new Window(),
               new Window(),
               new Window(),
               new Window(),
                new Part()

            };

            foreach (IPart asa in asaa)
            {

                Console.WriteLine(asa.ToString());

            }

                Console.WriteLine(Work.Worke(asaa[^1]));
                Console.WriteLine(teamleader.Worke(asaa[^1]));
            

           

                
            

        }
        



    }
}
