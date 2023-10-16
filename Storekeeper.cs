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
        public void acceptProduct(Product product) {
            Console.WriteLine("Storekeeper принял товар");
        }

        public void takeInventory(List<Product> section) {
            Console.WriteLine("Storekeeper провел инвентаризацию");

        }
    }
}
