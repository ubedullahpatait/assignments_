using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Display
    {
        public float UserInput()
        {
            Console.WriteLine("Enter height in meters ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight in KG ");
            float weight = float.Parse(Console.ReadLine());

            CalculateBMI bmi = new CalculateBMI();
            float calculateHeightAndWeight = bmi.Calculate(height, weight);

            return calculateHeightAndWeight;
        }
    }
}
