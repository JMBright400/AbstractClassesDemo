using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public bool HasSteeringWheel { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a car");
        }

    }
}
