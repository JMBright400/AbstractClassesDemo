using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public bool HasFourWheels { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This is an overridden DriveVirtual for a motorcycle.");
        }
    }
}
