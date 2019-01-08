using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestCalculator.Utils
{
    public class CalculatorData
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public char Operation { get; set; }

        public CalculatorData(int num1, int num2, char operation)
        {
            Num1 = num1;
            Num2 = num2;
            Operation = operation;
        }
    }
}
