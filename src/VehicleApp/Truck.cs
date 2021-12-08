using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class Truck : BaseVehicle
    {
        public bool SupperCab { get; set; }

        public Truck() :
            base("Ford", "F-150", 14, false)
        {
            this.SupperCab = true;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("This is{0}a supper cab truck!", (this.SupperCab ? " " : " not "));
        }

        public void Display2()
        {
            Console.WriteLine("This is dipslay 2 in child.");
        }
    }
}
