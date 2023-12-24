using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(string adress, double distance)
        {
            Address = adress;
            Distance = distance;
            Price = Math.Round(Distance / 10 + Distance / 10 * 0.1, 2);
            Weight = new Random().Next(1, 100);
        }

        public override void DeliveryInfo()
        {
            Console.WriteLine("Доставка до пункта выдачи");
            Console.WriteLine($"Адрес - {Address} \nРасстояние - {Distance} \nЦена - {Price} руб. \nВес - {Weight} кг.");
        }
    }
}
