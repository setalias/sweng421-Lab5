﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Product : Operation
    {
        public override double perform(double value)
        {
            return Operation.Value *= value;
        }
    }
}
