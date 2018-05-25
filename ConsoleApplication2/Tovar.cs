using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    abstract class Tovar
    {
        private double _Price;
        private Nomenklatura _Name_nomenklatura;

        public double Price {
            get
            {
                return _Price;
            }
            set
            {
                if (value > 0)
                    _Price = value;
                else
                    Console.WriteLine("Неверное значение цены");
            }
        }
        public Nomenklatura Name_nomenklatura
        {
            get
            {
                if (_Name_nomenklatura == null)
                    throw new Exception("Номенклатуры нет");
                else
                    return _Name_nomenklatura;
            }
            set
            {
                _Name_nomenklatura = value;
            }
        }
        public Tovar(Nomenklatura Name_nomenklatura, double Price)
        {
            this.Name_nomenklatura = Name_nomenklatura;
            this.Price = Price;
        }

        public abstract string TovarInfo();
    }
}
