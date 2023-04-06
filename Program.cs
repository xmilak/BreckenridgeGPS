using BreckenridgeGPS;

Console.WriteLine("Breckenridge GPS App");
Console.ReadKey();
Console.WriteLine("This app only operates for Peak 8 and 9 for now!");
Console.ReadKey();
Console.WriteLine("Choose from one of the options");
Console.WriteLine("Press 1. display all of the trails at Peak 8");
Console.WriteLine("Press 2. display all of the trails at Peak 9");
Console.WriteLine("Press 3. to recieve info on how to get to certain trail");
Console.WriteLine("Press 4. to find out which trails to take to get to gondola");
Console.WriteLine("Press 5. to find out which trails to take to get to parking garage");

string input = Console.ReadLine();
int option = int.Parse(input);

var peaks = new List<Peak>();

var peak8 = new Peak
{
    PeakNumber = 8,
    Name = "Peak 8",
    Trails = Seed.GetAllPeak8Trails()
};

var peak9 = new Peak
{
    PeakNumber = 9,
    Name = "Peak 9",
    Trails = Seed.GetAllPeak9Trails()
};

peaks.Add(peak8);
peaks.Add(peak9);

switch (option)
{
    case 1:
        peak8.GetAllTrails();
        break;
    case 2:
        peak9.GetAllTrails();
        break;
    case 3:
        InfoTrail.DisplayTrailInfo(peaks);
        break;
    case 4:GetGondola.DisplayTrailInfo(peaks);
        break;
    case 5:Parking.DisplayTrailInfo(peaks);
        break;
}