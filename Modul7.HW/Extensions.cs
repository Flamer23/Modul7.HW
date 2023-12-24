using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    static class Extensions
    {
        public static void MakeDiscount(this Product product)
        {
            product.Price -= product.Price * 0.1;
            Console.WriteLine($"Сделана скидка на {product.Name}!");
        }
    }
}
