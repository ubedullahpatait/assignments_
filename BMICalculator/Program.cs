using System;
namespace BMICalculator
{
    class Program
    {
        static void Main()
        {


            Display input = new Display();
            float showMessage = input.UserInput();

            ValidateUserInput validateStatus = new ValidateUserInput();
            String display = validateStatus.DisplayMessage(showMessage);
            Console.WriteLine("Check Status " + display);
        }
    }
}

