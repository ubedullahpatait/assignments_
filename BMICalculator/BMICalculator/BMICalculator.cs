using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        
       
            public double CalculateBMI(double height, double Weight)
            {
                double BMI = Weight / height;
                return BMI;
            }

            public string Calculate(double bMI)
            {
                if (bMI < 18.5)
                    return "underweight";
                else if (bMI >= 25)
                    return "overweight";
                else
                    return "healthy";
            }
        }
    }


