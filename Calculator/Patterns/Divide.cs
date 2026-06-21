using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Patterns
{
    internal class Divide : IOperation
    {
        public int DoOperation(int i, int j)
        {
            return i / j;
        }
    }
}
