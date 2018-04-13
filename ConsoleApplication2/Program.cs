using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {       
            Nomenklatura skripka_nomenklatura = new Nomenklatura("skripka", new DateTime(2018, 01, 28));
            Nomenklatura gitara_nomenklatura = new Nomenklatura("gitara", new DateTime(2018, 02, 05));
            Nomenklatura baraban_nomenklatura = new Nomenklatura("baraban", new DateTime(2017, 01, 05));
           
            Gitara tovar1 = new Gitara(gitara_nomenklatura, 15000, "electric_guitar", "YAMAHA", new DateTime(2015, 03, 07));
            Skripka tovar2 = new Skripka(skripka_nomenklatura, 50000, "Crafter", 1, new DateTime(2017, 05, 08));

            List<Tovar> ListTovar = new List<Tovar>();
            ListTovar.Add(tovar1);
            ListTovar.Add(tovar2);

            foreach (Tovar t in ListTovar)
            {
                Console.WriteLine(t.tv());
            }

            Console.ReadLine();
        }
    }
    }

