using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestCalculator.Utils
{
    public static class CalculatorHelper
    {
        public static double DoOperation(double value1, double value2, string operation)
        {
            switch (operation)
            {
                case "+":
                case "Add":
                    return value1 + value2;
                case "-":
                case "Subtract":
                    return value1 - value2;
                case "*":
                case "Multiply":
                    return value1 * value2;
                case "/":
                case "Divide":
                    return value1 / value2;

                default:
                    throw new InvalidOperationException("[CalculatorHelper::DoOperation] - Unexpected Operation Input.");
            }
        }

        public static string GetOperationName(char operation)
        {
            switch (operation)
            {
                case '+': return "Add";
                case '-': return "Subtract";
                case '*': return "Multiply";
                case '/': return "Divide";

                default:
                    throw new InvalidOperationException("[CalculatorHelper::GetOperationName] - Received invalid input for operator.");
            }
        }

        public static char GetOperationOperator(string operation)
        {
            switch (operation)
            {
                case "Add": return '+';
                case "Subtract": return '-';
                case "Multiply": return '*';
                case "Divide": return '/';

                default:
                    throw new InvalidOperationException("[CalculatorHelper::GetOperationOperator] - Received invalid input for operator.");
            }
        }
    }
}
