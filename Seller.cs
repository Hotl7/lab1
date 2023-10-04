using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Seller :Worker
    {
        public Seller(string name,string phoneNumber) {
            this.name = name;
            this.phoneNumber = phoneNumber; 

        }

        public void sellProduct(Product product) { }

    }
}
