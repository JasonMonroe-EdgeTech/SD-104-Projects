using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Game_of_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string strPlayAgain;

            do
            {
                int nToothpicks = 23;
                int nUserPick, nCpuPick = 0;

                //Game instructions
                Console.WriteLine("~~~~~~Game of 23~~~~~~");
                Console.WriteLine("Pick either 1, 2, or 3 toothpicks from the pile.");
                Console.WriteLine("I will pick after you.  Last unintelligent entity to draw a toothpick looses");

                do
                {

                    //display toothpicks
                    for (int i = 0; i < nToothpicks; i++)
                    {
                        if (i % 4 == 0)
                        {
                            Console.Write("/");
                        }
                        else if (i % 4 == 1)
                        {
                            Console.Write("|");
                        }
                        else if (i % 4 == 2)
                        {
                            Console.Write("_");
                        }
                        else
                        {
                            Console.Write("\\");
                        }
                    }

                    Console.WriteLine("Pick 1, 2 or 3 toothpicks");
                    while (!int.TryParse(Console.ReadLine(), out nUserPick) || (nUserPick < 1 || nUserPick > 3))
                    {
                        Console.WriteLine("Not a valid entry.  Must be a number.");
                        Console.WriteLine("Pick 1, 2 or 3 toothpicks");
                    }

                    nToothpicks -= nUserPick;

                    //computer's choice
                    if (nToothpicks > 4)
                    {
                        nCpuPick = 4 - nUserPick;
                        Console.WriteLine("I pick " + nCpuPick);
                    }
                    else if (nToothpicks > 1 && nToothpicks < 4)
                    {
                        nCpuPick = nToothpicks - 1;
                        Console.WriteLine("I pick " + nCpuPick + " you loose");
                    }
                    else if (nToothpicks == 1)
                    {
                        nCpuPick = 1;
                        Console.WriteLine("I pick " + nCpuPick + " you win!!");
                    }

                    nToothpicks -= nCpuPick;

                } while (nToothpicks > 1);


                Console.WriteLine("Do you want to play again? Type Y for yes.");
                strPlayAgain = Console.ReadLine();


            } while (strPlayAgain == "Y" || strPlayAgain == "y");

        }
    }
}
