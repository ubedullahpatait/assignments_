using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class calculate
    {
        
        calculate(int weight , double height , int BMI )
        {
            

            if(BMI<18.5)
            {
                Console.WriteLine("underweight");

            }
            else if (BMI >= 25)
            {
                Console.WriteLine("healthy");
            }

        }
    }
}
