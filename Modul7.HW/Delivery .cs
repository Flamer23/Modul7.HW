using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    abstract class Delivery
    {
        private string address;
        private double distance;
        private double price;
        private int weight;
        public string Address { get { return address; } set { if (value != null) { address = value; } } }
        public double Distance { get { return distance; }set { if (value > 0) { distance = value; } } }
        public double Price { get { return price; }set { if (value > 0) { price = value; } } }
        public int Weight { get { return weight; }set { if (value > 0) { weight = value; } } }



        public virtual void DeliveryInfo()
        {
            Console.WriteLine($"{Address}, {Distance}, {Price}, {Weight}");
        }
    }
}
