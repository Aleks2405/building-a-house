﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace building_a_house
{
    public interface IWorker  
    {
      public void Work (IPart part);

        public virtual string ToString ()
        {
            return $"";
        }

    }
}
