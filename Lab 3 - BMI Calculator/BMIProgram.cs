using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            double dblHeight;
            double dblWeight;
            double dblBMI;

            //user input
            Console.Write("Enter your Height in inches: ");

            //validate loop
            while (!double.TryParse(Console.ReadLine(), out dblHeight))
            {
                Console.WriteLine("Not valid.  Must be an rational number. Enter again: ");
            }

            Console.Write("Enter your Weight in pounds: ");

            while (!double.TryParse(Console.ReadLine(), out dblWeight))
            {
                Console.WriteLine("Not valid.  Must be an rational number. Enter again: ");
            }

            //calculations
            dblBMI = (dblWeight * 703) / (dblHeight * dblHeight);

            //display result
            Console.WriteLine("Your BMI is " + dblBMI);

            //display message
            if(dblBMI < 18.5)
            {
                Console.WriteLine("BMI < 18.5 - Underweight");
            }
            else if(dblBMI <= 24.9)
            {
                Console.WriteLine("BMI between 18.5 and 24.9 - Normal");
            }
            else if(dblBMI <= 29.9)
            {
                Console.WriteLine("BMI between 25 and 29.9 - Overweight");
            }
            else
            {
                Console.WriteLine("BMI >= 30 - Obese");
            }

            Console.ReadLine();
        }
    }
}
