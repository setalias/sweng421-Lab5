﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    interface IOperationFactory
    {
        IOperation createOperation(string operationClass);
    }
}
