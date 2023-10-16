using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class ProductExpert :Worker,ICanAcceptProduct
    {
        public ProductExpert(string name,string phoneNumber) {
            this.name = name;
            this.phoneNumber = phoneNumber;
            Console.WriteLine("Создался объект ProductExpert");

        }
        public void acceptProduct(Product product) {
            Console.WriteLine("ProductExpert принял товар");
        }

        public void refundProduct(Product product) {
            Console.WriteLine("ProductExpert сделал возврат товара");
        }


        public void deleteProduct(Product product) {
            Console.WriteLine("ProductExpert снял товар с продажи");

        }
    }
}
