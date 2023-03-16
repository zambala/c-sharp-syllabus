﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public struct Product
    {
        public int Available { get; set; }
        public Money Price { get; set; }
        public string Name { get; set; }

        public Product(string name, Money price, int count)
        {
            Name = name;
            Price = price;
            Available = count;
        }
        public override string ToString()
        {
            return $"{Name} - {Price} | {Available} left";
        }
    }
}
