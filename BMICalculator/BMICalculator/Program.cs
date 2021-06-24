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
            Console.WriteLine("Enter height in meters");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight in KG");
            float weight = float.Parse(Console.ReadLine());
            float BMI = bMICalculator.CalculateBMI(height, weight);
            string status = bMICalculator.CheckStatus(BMI);
            Console.WriteLine(status);

        }
    }
}
