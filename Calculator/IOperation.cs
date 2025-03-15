using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IOperation
    {
        public int DoOperation(int i, int j);
    }
}
