﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreckenridgeGPS
{
    public class InfoTrail
    {
        public static void DisplayTrailInfo(List<Peak> peaks)
        {
            Console.WriteLine("Where is the trail located?" +
                "Enter 8 for Peak 8." +
                "Enter 9 for Peak 9");

            int choice = Int32.Parse(Console.ReadLine());

            var selectedPeak = peaks.FirstOrDefault(f => f.PeakNumber == choice);
            
            if (selectedPeak == null)
                Console.WriteLine($"Invalid peak selected.");

            selectedPeak.GetAllTrails();



            Console.WriteLine($"Here's list of trails on Peak {choice}. Pick a number for which trail you would like to get info.");

            int trailChoice = Int32.Parse(Console.ReadLine());


            var selectedTrail = selectedPeak.Trails.FirstOrDefault(f => f.TrailNumber == trailChoice);

            if (selectedPeak == null)
                Console.WriteLine($"Invalid trail selected.");

            Console.WriteLine(selectedTrail.GetTo);
        }

    }
}
