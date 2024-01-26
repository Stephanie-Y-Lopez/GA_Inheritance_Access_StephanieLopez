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
            Vehicle vehicle = new Vehicle("Red");
            LandVehicle land = new LandVehicle("Purple", 4);
            AirVehicle air = new AirVehicle("Green");
            SeaVehicle sea = new SeaVehicle("Orange", "Submarine");
            PlaneAir plane = new PlaneAir("Pink", 3);
            HelicopterAir helicopter = new HelicopterAir("Blue", 2);

            // Create a global List of Vehicle
            vehicles.Add(vehicle);
            vehicles.Add(land);
            vehicles.Add(air);
            vehicles.Add(sea);
            vehicles.Add(plane);
            vehicles.Add(helicopter);
        

            // Using this loop will display the ToString information for each vehicle!
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine(v);
            }
        }
    }
}