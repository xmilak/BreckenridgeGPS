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

//Peak_8.GetAllTrails();

switch (option)
{
    case 1:
        Peak_8.GetAllTrails();
        break;
    case 2:
        Peak_9.GetAllTrails();
        break;
}