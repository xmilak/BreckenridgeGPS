using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreckenridgeGPS
{
    public class InfoTrail
    {
        public static void DisplayTrailInfo()
        {
            Console.WriteLine("Where is the trail located?" +
                "Enter 1 for Peak 8." +
                "Enter 2 for Peak 9");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    switch (choice)
                    {
                        case 1:
                            break;

                    }
                       
                        break;

                case 2: Console.WriteLine();
                        break;
                    
                default: 
                    Console.WriteLine("Invalid choice. Please enter either 1 or 2");
                    break;
                 
            }
        }

    }
}
