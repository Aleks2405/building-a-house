using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    public interface IWorker  
    {
     public  string Worke (IPart part)
        {
            return part.Name;
        }

        public virtual string ToString()
        {
            return $"";
        }

    }
    }
