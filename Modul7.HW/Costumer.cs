using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    internal class Costumer<T> : Person<T>
    {
        private int id;

        public int Id { get { return id; } set { if (value != 0) id = value; } }

        public Costumer(string name, T date, int id)
        {
            this.Name = name;
            this.DateOfBirth = date;
            this.Id = id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя - {Name}\nДата рождения - {DateOfBirth}\nИндивидуальный номер - {Id}");
        }
    }
}
