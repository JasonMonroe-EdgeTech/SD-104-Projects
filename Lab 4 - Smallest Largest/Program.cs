using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Smallest_Largest
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int nSmallest;
            int nLargest;
            int nCurrent;
            string strEntry;

            //first integer
            Console.Write("Enter an integer: ");
            nLargest = nSmallest = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another integer or Q to Quit: ");
            strEntry = Console.ReadLine();

            //loop
            while(strEntry != "Q")
            {
                nCurrent = Convert.ToInt32(strEntry);

                //check to see if input should replace largest or smallest
                if(nCurrent > nLargest)
                {
                    nLargest = nCurrent;
                }
                else if(nCurrent < nSmallest)
                {
                    nSmallest = nCurrent;
                }

                //prompt user
                Console.Write("Enter another integer or Q to Quit: ");
                strEntry = Console.ReadLine();
            }

            //print results
            Console.WriteLine("The largest value you entered was " + nLargest);
            Console.WriteLine("The smallest value you entered was " + nSmallest);

            Console.ReadLine();

        }
    }
}
