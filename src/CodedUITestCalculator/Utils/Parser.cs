using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedUITestCalculator.Utils
{
    public class Parser
    {
        private readonly string filePath;

        public List<CalculatorData> Data { get; private set; }

        public Parser(string filePath)
        {
            this.filePath = filePath;
        }

        public bool Parse()
        {
            if (String.IsNullOrEmpty(filePath))
                throw new InvalidOperationException("[Parser::Parse] - Parser filePath cannot be empty.");

            Data = new List<CalculatorData>();

            string[] data = File.ReadAllLines(filePath);
            for (int i = 1; i < data.Length; i++) // starting iteration from 1 as we are not interested in the columns headers.
            {
                string[] row = data[i].Split('\t');
                try
                {
                    int num1 = Convert.ToInt32(row[0]);
                    int num2 = Convert.ToInt32(row[1]);
                    char operation = row[2][0];

                    Data.Add(new CalculatorData(num1, num2, operation));
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }
    }
}

