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
        public Nomenklatura ID { get; set; }
        public Tovar(Nomenklatura ID, double Price)
        {
            this.ID = ID;
            this.Price = Price;
        }

        public abstract string tv();
    }
}
