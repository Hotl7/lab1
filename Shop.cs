using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Shop
    {
        private string name;
        private string adress;
        private double money;
        private List<Product> assortment { get;set; } = new List<Product>();
        private List<Worker> staff { get; set; } =new List<Worker>();


        public Shop(string address) {
            this.adress = address;
            Console.WriteLine("Создался объект Shop");
        }
        public Shop(string name,string address, double money)
        {
            this.adress = address;
            this.money = money;
            this.name = name;
            Console.WriteLine("Создался объект Shop");
            
        }

        public void addProduct(Product product)
        {
            Console.WriteLine("Магазин добавил Продукт");
        }
        public void hireWorker(string name, string phoneNumber, string post) {
            Console.WriteLine("Магазин нанял Сотрудника");
        }
        public void payTax(double tax) {
            Console.WriteLine("Магазин оплатил налоги");

        }
    }
}
