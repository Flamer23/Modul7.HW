using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    class Product
    {
        private string name;
        private string description;
        private double price;

        public string Name { get { return name; } set { if (value != null) { name = value; } } }
        public string Description { get { return description; } set { if (value != null) {  description = value; } } }
        public double Price { get { return price; } set { if (value > 0) price = value; } }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Название - {Name} \nОписание - {Description} \nЦена - {Price} руб.");
        }
    }
}
