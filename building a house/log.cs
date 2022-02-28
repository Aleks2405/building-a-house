using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace building_a_house
{
    class log
    {
        public log(FileInfo file, IPart[] asaa)
        {
            
            using (FileStream fs = file.Open(FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter f = new StreamWriter(fs))
                    foreach (IPart asa in asaa)
                    {
                        f.WriteLine(asa);

                    }
            }
        }
    }
}
