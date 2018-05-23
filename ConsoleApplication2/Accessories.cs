using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Accessories: Tovar, IAccessories
    {
        private string _Name;

        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(_Name))
                    throw new Exception("Название аксессуара не может быть пустым");
                else
                    return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public Nomenklatura TovarCcategory { get; set; }

        public Accessories(Nomenklatura ID, string Name, double Price, Nomenklatura TovarCcategory) : base(ID, Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
        public override string tv()
        {
            return "\nНоменклатура: " + ID + "\nЦена: " + Price;
        }
    }
}
