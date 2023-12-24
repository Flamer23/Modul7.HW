namespace Modul7.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeDelivery homeDelivery = new HomeDelivery("Moscow", 1593);
            homeDelivery.DeliveryInfo();
            Console.WriteLine();

            PickPointDelivery pickPointDelivery = new PickPointDelivery("Moscow", 1593);
            pickPointDelivery.DeliveryInfo();
            Console.WriteLine();

            ShopDelivery shopDelivery = new ShopDelivery("Moscow", 1593);
            shopDelivery.DeliveryInfo();
            Console.WriteLine();

            Product car = new Product("Машинка", "Детская игрушка для мальчиков", 100);
            Product doll = new Product("Кукла", "Детская игрушка для девочек", 120);

            List<Product> products = new List<Product>();
            products.Add(car);
            products.Add(doll);

            Order<ShopDelivery> order = new Order<ShopDelivery>(shopDelivery, products,"Обычная");
            order.OrderInfo();
            Console.WriteLine();

            Card card = new Card("Сбер", "0000 0000 0000 0000", 111);
            Card card2 = new Card("Альфа", "1111 1111 1111 1111", 222);
            Card card3 = new Card("Тинькоф", "2222 2222 2222 2222", 333);
            Card card4 = new Card("Киви", "3333 3333  3333 3333", 444);
            CardCollection cardCollection = new CardCollection();
            cardCollection.Add(card);
            cardCollection.Add(card2);
            CardCollection cardCollection1 = new CardCollection();
            cardCollection1.Add(card3); 
            cardCollection1.Add(card4);
            CardCollection cardCollection2 = cardCollection + cardCollection1;

            Console.WriteLine(cardCollection2[3].BankName);
            Console.WriteLine();

            card3.ShowInfo(card3.Number);
            Console.WriteLine();

            car.ShowInfo();
            Console.WriteLine();
            car.MakeDiscount();
            Console.WriteLine();
            car.ShowInfo();
            Console.WriteLine();

            Costumer<string> costumer = new Costumer<string>("Илья", "14.08.2002", 844855);
            costumer.ShowInfo();


        }
    }
}
