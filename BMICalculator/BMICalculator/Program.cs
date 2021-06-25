using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalculator bMICalculator = new BMICalculator();
            double BMI = bMICalculator.CalculateBMI(5.1, 60);
            string calculateResult = bMICalculator.Calculate(BMI);
            Console.WriteLine(calculateResult);

        }
    }
}
