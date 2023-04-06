using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreckenridgeGPS
{
    public class Parking
    {
        public static void DisplayTrailInfo(List<Peak> peaks)
        {
            Console.WriteLine("I see that you're trying to get to the parking. " +
                "What peak are you at please enter a number. ");

            int choice = Int32.Parse(Console.ReadLine());

            var selectedPeak = peaks.FirstOrDefault(f => f.PeakNumber == choice);

            if (selectedPeak == null)
                Console.WriteLine("Invalid peak selected");

            selectedPeak.GetAllTrails();

            Console.WriteLine($"What traile are you on at Peak {choice}? Pick a number.");

            int trailChoice = Int32.Parse(Console.ReadLine());

            var selectedTrail = selectedPeak.Trails.FirstOrDefault(f => f.TrailNumber == trailChoice);

            if (selectedTrail == null)
                Console.WriteLine("Invalid trail selected.");
            Console.WriteLine(selectedTrail.Parking);

        }
    }
}
