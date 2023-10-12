using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; } = "Unknown";
        public string Make { get; set; } = "Unknown";
        public string Model { get; set; } = "Unknown";

           public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is the base implementation of DriveVirtual for a vehicle");
        }

    }
}
