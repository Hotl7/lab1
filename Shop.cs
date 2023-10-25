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
        private List<Product> assortment = new List<Product>();
        private List<Worker> staff = new List<Worker>();


        public Shop(string address) {
            this.adress = address;
            Console.WriteLine("Создался объект Shop");
        }
        public Shop(string address, double money)
        {
            this.adress = address;
            this.money = money;
           
            Console.WriteLine("Создался объект Shop");
            
        }


        public void addProduct(Product product)
        {
            assortment.Add(product);
        }

        public void updateAssortment(string name, int amount)
        {
            foreach(var item in assortment)
            {
                if(item.Name == name) { item.Amount = amount; } 
            }
            
        }
        public void hireWorker(string name, string phoneNumber, string post) {
            Console.WriteLine("Магазин нанял Сотрудника");
        }
        public void payTax(double tax) {
            Console.WriteLine("Магазин оплатил налоги");

        }
        public bool searchProductInAssortment(string name)
        {
            foreach (var item in assortment)
            {
                if (item.Name == name) { return true; }
                
            }
            return false;

        } 
    }
}
