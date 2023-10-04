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
            
        }
        public void acceptProduct(Product product) { }

        public void refundProduct(Product product) { }


        public void deleteProduct(Product product) { }
    }
}
