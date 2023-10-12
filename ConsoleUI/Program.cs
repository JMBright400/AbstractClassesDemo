using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles
            
            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car { Year = "2023", Make = "BMW", Model = "7 Series", HasSteeringWheel = true };
            Motorcycle motorcycle = new Motorcycle { Year = "2023", Make = "KTM", Model = "790 Duke", HasFourWheels = false};

            Vehicle standardVehicle1 = new Car { Year = "2023", Make = "Generic", Model = "Standard", HasSteeringWheel = true };
            Vehicle standardVehicle2 = new Motorcycle { Year = "2023", Make = "Generic", Model = "Standard", HasFourWheels = false };

            vehicles.Add(car);
            vehicles.Add(motorcycle); 
            vehicles.Add(standardVehicle1);
            vehicles.Add(standardVehicle2 );

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }

            car.DriveAbstract();
            car.DriveVirtual();

            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();


            #endregion            
            Console.ReadLine();
        }
    }
}
