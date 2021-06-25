using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class CalculateBMI
    {
        public float Calculate(float height, float weight)
        {
            float BMI = weight / height;
            return BMI;
        }
    }
}
