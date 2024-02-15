using System.Numerics;

namespace GA_Inheritance_Access_StephanieLopez
{
    internal class Program
    {
        //Stephanie Lopez
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            // Create instances of each class
            Vehicle vehicle = new Vehicle("Color: Red");
            Air air = new Air("Color: Green");
            Helicopter helicopter = new Helicopter("Color: Blue - ", 2);
            Plane plane = new Plane("Color: Pink - ", 3);
            Sea sea = new Sea("Color: Orange - ", "Submarine");
            Land land = new Land("Color: Purple - ", 4);

            // Create a global List of Vehicle
            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);


            // Using this loop will display the ToString information for each vehicle!
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}