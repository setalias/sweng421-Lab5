using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5
{
    class Log : Operation
    {
        public override double perform(Input value)
        {
            return Math.Log10(Operation.Value);
        }
    }
}
