using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal abstract class Worker
    {
        protected string name;
        protected string phoneNumber;

        public void hasArrived() {
            Console.WriteLine("Сотрудник прибыл на работу");

        }
    }
}
