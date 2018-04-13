using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Accessories: Tovar, IAccessories
    {
        public string Name { get; set; }
        public string Product_Accessory { get; set; }
        public Nomenklatura TovarCcategory { get; set; }

        public Accessories(Nomenklatura ID, string Name, double Price, Nomenklatura TovarCcategory) : base(ID, Price)
        {
            this.Name = Name;
            this.Price = Price;
            this.Product_Accessory = Product_Accessory;
        }
        public override string tv()
        {
            return Name + ", " + Price + ", " + Product_Accessory;
        }
    }
}
