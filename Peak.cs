using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreckenridgeGPS
{
    public class Peak
    {
        public string Name { get; set; }
        public List<Trail> Trails { get; set; } = new List<Trail>();
        public int PeakNumber { get; set; }

        public void GetAllTrails()
        {
            foreach (var trail in Trails)
            {
                Console.WriteLine(trail.TrailNumber + ". " + trail.Name);
            }
        }
    }
}
