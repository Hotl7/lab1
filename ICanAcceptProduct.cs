﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal interface ICanAcceptProduct
    {
         void acceptProduct(string name,double price,string acceptedBy,int amount,Shop shop);
    }
}
