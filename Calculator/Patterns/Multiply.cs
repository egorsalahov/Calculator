using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Patterns
{
    internal class Multiply : IOperation
    {
        public void DoOperation(int i, int j)
        {
            Console.WriteLine(i * j);
        }
    }
}
