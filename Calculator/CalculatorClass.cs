using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalculatorClass
    {
        private IOperation _operation;

        public void SetOperation(IOperation operation) { _operation = operation; }

        public int DoCalulate(int i, int j)
        {
            return _operation.DoOperation(i, j);
        }
    }
}
