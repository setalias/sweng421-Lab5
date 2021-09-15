using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5
{
    class Log : Operation
    {
        public override double perform(double value = 0)
        {
            return Math.Log(Operation.Value);
        }
    }
}
