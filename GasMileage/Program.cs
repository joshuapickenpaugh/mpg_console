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
            float fltMPG = 0;
            string strMPG;
            float fltAverageMpg = 0;

            List<float> MpgList = new List<float>();


            while (intChoice == 1)
            {
                //Asks user for input:
                Console.Write("Input the miles driven:");
                intMiles = Convert.ToInt32(Console.ReadLine());

                //Asks user for input:
                Console.Write("Input the gallons used to fill up tank:");
                intGallons = Convert.ToInt32(Console.ReadLine());

                //Gets the individual MPG for this round of user input, adds it to the list of MPGs:
                fltMPG = IndividualMPG(intMiles, intGallons);
                MpgList.Add(fltMPG);

                //Gets average of individual tanks:
                fltAverageMpg = AverageTankMPG(MpgList);

                //Displays average MPG:
                strMPG = fltMPG.ToString("N2");

                //Displays:
                Console.WriteLine("Individual Tank MPG: {0}", strMPG);

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

            //Gets each value in list, adds them up:

            //Gets Count of values in list:

            //Divides total value sum by Count:

            //Return average MPG:
            return
        }
    }
}
