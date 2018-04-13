﻿using System;
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
            Nomenklatura mediator_nomenklatura = new Nomenklatura("Mediator", new DateTime(2018, 01, 28));

            Gitara tovar1 = new Gitara(gitara_nomenklatura, 15000, "electric_guitar", "YAMAHA", new DateTime(2015, 03, 07));
            Skripka tovar2 = new Skripka(skripka_nomenklatura, 50000, "Crafter", 1, new DateTime(2017, 05, 08));
            Accessories tovar3 = new Accessories(mediator_nomenklatura, "Mediator", 100, gitara_nomenklatura);

            List<Tovar> ListTovar = new List<Tovar>();
            ListTovar.Add(tovar1);
            ListTovar.Add(tovar2);
            ListTovar.Add(tovar3);

            foreach (Tovar t in ListTovar)
            {
                Console.WriteLine(t.tv());
            }
            Console.WriteLine("Из них аксессуары:");
            foreach (Tovar t in ListTovar.Where(i1 => i1 is IAccessories))
            {
                Console.WriteLine(t.tv());
            }

            Console.ReadLine();
        }
    }
    }

