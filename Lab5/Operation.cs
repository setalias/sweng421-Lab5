using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{

    abstract class Operation : IOperation
    {

        private static double value = 6;

        public abstract double perform(Input value);

        public static double Value
        {
            get => Operation.value;
            set => Operation.value = value;
        }
        
    }
}
