using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Skripka: Tovar
    {
        public string Marka_instrumenta { get; set; }
        public double Size { get; set; }
        public DateTime Release_data { get; set; }

        public Skripka(Nomenklatura ID, double Price, string Marka_instrumenta, double Size, DateTime Release_data) : base(ID, Price)
        {
            this.Marka_instrumenta = Marka_instrumenta;
            this.Size = Size;
            this.Release_data = Release_data;
        }
        public override string tv()
        {
            return ID + ", " + Marka_instrumenta + ", " + Size + ", " + Release_data.ToString("dd MMMM yyyy") + ", " + Price;
        }
    }
}
