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
            Shop shop=new Shop("пр-т Ленина,66",10000);
            Product prod = new Product("prod1", 199, "stKpr 1", 10);
            Storekeeper strKpr = new Storekeeper("stKpr1", "202-101"); 
            shop.hireWorker("storeKeeper", "333-000", "stKeeper");
            strKpr.acceptProduct("prod1", 199, "stKpr 1", 10, shop);
            




        }
    }
}
