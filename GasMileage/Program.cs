//Joshua Pickenpaugh
//July 23, 2017
//MPG Console application. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local variables:
            int intChoice = 1;
            int intMiles = 0;
            int intGallons = 0;
            float fltMpg = 0;
            string strMpg;
            string strAveMpg;
            float fltAverageMpg = 0;

            //List to hold the MPGs:
            List<float> MpgList = new List<float>();


            while (intChoice == 1)
            {
                //Asks user for input:
                Console.Write("Input the miles driven:");
                intMiles = Convert.ToInt32(Console.ReadLine());

                //Asks user for input:
                Console.Write("Input the gallons used to fill up tank:");
                intGallons = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                //Gets the individual MPG for this round of user input, adds it to the list of MPGs:
                fltMpg = IndividualMPG(intMiles, intGallons);
                MpgList.Add(fltMpg);

                //Gets average of individual tanks:
                fltAverageMpg = AverageTankMPG(MpgList);

                //Converts ind. and average MPGs to hundreths:
                strMpg = fltMpg.ToString("N2");
                strAveMpg = fltAverageMpg.ToString("N2");

                //Displays:
                Console.WriteLine("Individual Tank MPG: {0}", strMpg);
                Console.WriteLine("Average MPG: {0}", strAveMpg);

                //User selection menu:
                Console.WriteLine("_________________________________");
                Console.WriteLine("1. Enter more data.");
                Console.WriteLine("2. QUIT");
                intChoice = Convert.ToInt32(Console.ReadLine());
            }

        }

        //Gets a MPG calculation for an individual set of user input:
        public static float IndividualMPG(int miles, int gallons)
        {
            float mpg = 0;

            mpg = miles / gallons;

            return mpg; 
        }

        ////Gets average MPG of the individual tanks:
        public static float AverageTankMPG(List<float> mpglist)
        {
            float avgMpg = 0;
            float listTtl = 0;
            int listCount = 0;

            //Sums the values in the mpg list:
            listTtl = mpglist.Sum();

            //Gets Count of values in list:
            listCount = mpglist.Count();

            //Divides total value sum by Count:
            avgMpg = listTtl / listCount;

            //Return average MPG:
            return avgMpg;
        }
    }
}
