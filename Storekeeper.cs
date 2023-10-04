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
        }
        public void acceptProduct(Product product) { }

        public void takeInventory(Product[] section) { }
    }
}
