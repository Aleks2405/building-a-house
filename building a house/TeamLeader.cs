using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    class TeamLeader : IWorker

    {
        public string Worke(IPart part)
        {
            return part.Name + $" пишу отчет по проделанной работе";
        }
        //public List<IPart> parts = new List<IPart>();


        //public override string ToString() //печатает результат работы строителей и
        //                                  фиксирует результаты в списке
        //{
        //    part.Print_Res();
        //    return $" {parts.Remove(part)}";
        //}
    }
    
}
