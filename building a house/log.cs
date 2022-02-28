using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters;


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

            //using (Stream fsS = File.OpenRead("log.soap"))
            //{
            //    asaa = (IPart)soapFormat.Deserialize(fsS);
            //}
            
        }
        //public log(IPart[] a)
        //{
        //    //List<IPart> persons = new List<IPart>();
        //    //XmlSerializer xmlFormat = new XmlSerializer(typeof(List<IPart>));
        //    ////XmlSerializer xmlFormat = new XmlSerializer();
        //    //using (Stream fStream = File.Create("test.xml"))
        //    //{

        //    //    xmlFormat.Serialize(fStream, a);
        //    //}
        //    //    Console.WriteLine("XmlSerialize OK!\n");

        //    //    List<IPart> list = null;
        //    //    using (Stream fStream = File.OpenRead("test.xml"))
        //    //    {
        //    //        list = (List<IPart>)xmlFormat.Deserialize(fStream);


        //    //        using (StreamWriter f = new StreamWriter(fStream))
        //    //            foreach (IPart team in list)
        //    //            {
        //    //                f.WriteLine(team);
        //    //            }
        //    //    }
        //    }
        }

    }

            
