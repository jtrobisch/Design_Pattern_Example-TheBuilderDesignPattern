﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface Item
    {
         String name();
         Packing packing();
         float price();
    }
   
}
