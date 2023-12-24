using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    class Order<TDelivery> where TDelivery : Delivery
    {
        public static string Currency = "Рубли";

        private TDelivery delivery;

        private int id;

        private string description;

        private double price;

        private List<Product> products;


        protected int Id { get { return id; } set { if (value != 0) { id = value; } } }

        public string Description { get { return description; } set { if (value != null) { description = value; } } }

        private double Price { get { return price; } set { if (value != 0) { price = value; } } }

        public TDelivery Delivery { get { return delivery; } set { if (value != null) { delivery = value; } } }

        public List<Product> Products { get { return products; } set { if (value != null) { products = value; } } }


        public Order(TDelivery delivery, List<Product> products, string description)
        {
            Delivery = delivery;
            Id = new Random().Next(100000,999999);
            Description = description;
            Products = products;
            foreach (var item in products) 
            {
                Price += item.Price;
            }
            Price += Delivery.Price;
        }

        public Order(TDelivery delivery, string description)
        {
            Delivery = delivery;
            Id = new Random().Next(100000, 999999);
            Description = description;
            Products = new List<Product>();
            foreach (var item in products)
            {
                Price += item.Price;
            }
            Price += Delivery.Price;
        }

        public void OrderInfo()
        {
            Console.WriteLine($"Номер заказа - {Id} \nОписание - {Description} \nАдрес - {Delivery.Address}\nОбщая Сумма - {Price}");
        }


    }
}
