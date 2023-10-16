using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop=new Shop("Store1","пр-т Ленина,66",10000);
            Product prod = new Product("prod1", 199, "stKpr 1", 10);
            Worker[] workers = { 
                new Storekeeper("stKpr1", "202-101"),
                new ProductExpert("expert1","111-222"),
                new Seller("seller1","333-000") 
            };
            shop.hireWorker("seller1", "333-000", "seller");
            
            
            

        }
    }
}
