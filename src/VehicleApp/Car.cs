using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Car : BaseVehicle
    {
        public bool IsSportsCar { get; set; }
        public Car() :
            base("Chevy", "Impala", 28)
        {
            this.IsSportsCar = false;
        }

        public override void Display()
        {
            Console.WriteLine("I am a very cool car");
            base.Display();
        }
    }
}
