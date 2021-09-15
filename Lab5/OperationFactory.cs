using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class OperationFactory : IOperationFactory
    {
        public IOperation createOperation(string operationClass)
        {
            Type T = Type.GetType("Lab5." + operationClass);
            Object o = Activator.CreateInstance(T);
            return (IOperation)o;
        }
    }
}
