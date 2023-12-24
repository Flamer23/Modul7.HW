using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Modul7.HW
{
    internal class Card
    {
        private string bankName;
        private string number;
        private int cvv;
        private int pin;

        public string BankName { get { return bankName; } set { if (value != null) { bankName = value; } } }
        public string Number { get { return number; } set { if (value != null) { number = value; } } }
        public int Cvv { get { return cvv; } set { if ((value >= 100) && (value <= 999)) { cvv = value; } } }
        private int Pin { get { return cvv; } set { if ((value >= 1000) && (value <= 9999)) { cvv = value; } } }

        public Card(string bankName, string number, int cvv)
        {
            BankName = bankName;
            Number = number;
            Cvv = cvv;
            Pin = new Random().Next(1000,9999);
        }
        public void ShowInfo<T>(T value)
        {
            Console.WriteLine(value);
        }
        
    }
}
