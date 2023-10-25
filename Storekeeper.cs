using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Storekeeper :Worker,ICanAcceptProduct
    {
        public Storekeeper(string name, string phoneNumber) {
            this.name = name;
            this.phoneNumber = phoneNumber;
            Console.WriteLine("Создался объект Storekeeper");
        }
        public void acceptProduct(string name, double price, string acceptedBy, int amount,Shop shop)
        {
            bool retrn=shop.searchProductInAssortment(name);
            if (retrn)
            {
                shop.updateAssortment(name, amount);
            }
            else
            {
                Product product=new Product(name, price,acceptedBy,amount);
                shop.addProduct(product);
            }
        }

        public void takeInventory(List<Product> section) {
            Console.WriteLine("Storekeeper провел инвентаризацию");

        }
    }
}
