using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class BMICalculator
    {
        
       
            public float CalculateBMI(float height, float Weight)
            {
                float BMI = Weight / height;
                return BMI;
            }

            public string CheckStatus(float bMI)
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


