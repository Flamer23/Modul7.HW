using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    class HomeDelivery : Delivery
    {
        public HomeDelivery(string adress, double distance)
        {
            Address = adress;
            Distance = distance;
            Price =Math.Round(Distance / 10 + Distance / 10 * 0.2 , 2);
            Weight = new Random().Next(1,100);
        }

        public override void DeliveryInfo()
        {
            Console.WriteLine("Доставка до порога");
            Console.WriteLine($"Адрес - {Address} \nРасстояние - {Distance} \nЦена - {Price} руб. \nВес - {Weight} кг.");
        }
    }
}
