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
            List<Tovar> ListTovar = new List<Tovar>();

            Nomenklatura skripka_nomenklatura = new Nomenklatura("skripka", new DateTime(2018, 01, 28));
            Nomenklatura gitara_nomenklatura = new Nomenklatura("gitara", new DateTime(2018, 02, 05));
            Nomenklatura baraban_nomenklatura = new Nomenklatura("baraban", new DateTime(2017, 01, 05));
            ListTovar.Add(new Tovar(skripka_nomenklatura, 6000));
            ListTovar.Add(new Tovar(skripka_nomenklatura, 7000));
            ListTovar.Add(new Gitara(gitara_nomenklatura, 15000, "electric_guitar", "YAMAHA", new DateTime(2015, 03, 07)));
            ListTovar.Add(new Gitara(gitara_nomenklatura, 20000, "acoustic_guitar", "Crafter", new DateTime(2000, 01, 28)));
            ListTovar.Add(new Tovar(baraban_nomenklatura, 17000));


            foreach (Tovar t in ListTovar)
            {
                t.Get_info();
            }

            Console.ReadLine();
        }
    }
    }

