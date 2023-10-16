using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Product
    {
        private string name;
        private double price;
        private string acceptedBy;
        private int amount;

        public Product(string name, double price, string acceptedBy, int amount)
        {
            this.name = name;
            this.price = price;
            this.acceptedBy = acceptedBy;
            this.amount = amount;
            Console.WriteLine("Создался объект Product");
        }
    }
}
