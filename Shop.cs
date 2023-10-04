using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Shop
    {
        private string adress;
        private double money;
        private Product[] products;
        private Worker[] workers;


        public Shop(string address) { }
        public Shop(string address, double money) { }

        public void hireWorker(string name, string phoneNumber, string post) { }
        public void payTax(double tax) { }
    }
}
