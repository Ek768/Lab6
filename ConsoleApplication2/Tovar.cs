using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Tovar
    {
        public Nomenklatura ID { get; set; }
        public double Price { get; set; }

        public Tovar(Nomenklatura ID, double Price)
        {
            this.ID = ID;
            this.Price = Price;
        }

        public virtual void Get_info()
        {
            Console.WriteLine(ID.ToString() + ", " + Price.ToString());
        }
    }
}
