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
            Shop shop=new Shop("Московский тракт 89",9900000);
            Worker seller = new Storekeeper("Иванов Иван Иванович", "7-999-500-90-70");
            shop.hireWorker("Иванов Иван Иванович", "7-999-500-90-70", "продавец");
            seller.hasArrived();
            Product prod =new Product("Вино Цица",200, "Иванов Иван Иванович", 10);
            

        }
    }
}
