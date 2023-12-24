using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    class ShopDelivery : Delivery
    {
        public ShopDelivery(string adress, double distance)
        {
            Address = adress;
            Distance = distance;
            Price = 0;
            Weight = new Random().Next(1, 100);
        }

        public override void DeliveryInfo()
        {
            Console.WriteLine("Доставка до магазина");
            Console.WriteLine($"Адрес - {Address} \nРасстояние - {Distance} \nЦена - {Price} руб. \nВес - {Weight} кг.");
        }

    }
}
