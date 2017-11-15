/*
 *  Project: Lab 2 Batting Average
 *     Date: 11-13-2017
 *   Author: J.Monroe
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2___Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string strPlayerName;
            int nHits, nAtBats;
            double dblBattingAverage;

            //prompt user 
            Console.WriteLine("---Calculate Batting Average---");
            Console.Write("Enter the player's name: ");
            strPlayerName = Console.ReadLine();

            //prompt user for hits
            Console.Write("Enter the player's # of hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());

            //prompt user for number of at bats
            Console.Write("Enter the player's # of at bats: ");
            nAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = (double)nHits / nAtBats;

            //display results
            Console.WriteLine(strPlayerName + "'s batting average is " + dblBattingAverage);
            Console.ReadLine();


        }
    }
}
