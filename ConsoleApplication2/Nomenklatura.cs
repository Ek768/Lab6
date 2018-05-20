using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Nomenklatura
    {
        private string _Name;
        private DateTime _Data_registration;

        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(_Name))
                    throw new Exception("Название инструмента не может быть пустым");
                else
                    return _Name;
            }
            set
            {
                _Name = value;
            }
        }
            public DateTime Data_registration
        {
            get
            {
                if (_Data_registration == null)
                    throw new Exception("Укажите дату");
                else
                    return _Data_registration;
            }
            set
            {
                _Data_registration = value;
            }
        }
            public Nomenklatura(string Name, DateTime Data_registration)
            {
                this.Name = Name;
                this.Data_registration = Data_registration;
            }

            public override string ToString()
            {
                return Name;
            }
        }
}
