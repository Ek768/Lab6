using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Gitara: Tovar
    {
        private string _Vid_instrumenta;
        private string _Marka_instrumenta;
        private DateTime _Release_data;

        public string Vid_instrumenta
        {
            get
            {
                if (String.IsNullOrEmpty(_Vid_instrumenta))
                    throw new Exception("Вид инструмента не может быть пустым");
                else
                    return _Vid_instrumenta;
            }
            set
            {
                _Vid_instrumenta = value;
            }
        }
        public string Marka_instrumenta {
            get
            {
                if (String.IsNullOrEmpty(_Marka_instrumenta))
                    throw new Exception("Марка инструмента не может быть пустой");
                else
                    return _Marka_instrumenta;
            }
            set
            {
                _Marka_instrumenta = value;
            }
        }
        public DateTime Release_data
        {
            get
            {
                if (_Release_data == null)
                    throw new Exception("Укажите дату");
                else
                    return _Release_data;
            }
            set
            {
                _Release_data = value;
            }
        }

        public Gitara(Nomenklatura Name_nomenklatura, double Price, string Vid_instrumenta, string Marka_instrumenta, DateTime Release_data) : base(Name_nomenklatura, Price)
        {
            this.Vid_instrumenta = Vid_instrumenta;
            this.Marka_instrumenta = Marka_instrumenta;
            this.Release_data = Release_data;
        }
        public override string TovarInfo()
        {
            return "Номенклатура: " + Name_nomenklatura + "\nВид инструмента: " + Vid_instrumenta + "\nМарка инструмента: " + Marka_instrumenta + "\nДата производства: " + Release_data.ToString("dd MMMM yyyy") + "\nЦена: " + Price;
        }
    }
}
