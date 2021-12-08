using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    static internal class Display
    {
        public static void DisplayInterface(IVehicle vehicle)
        {
            Console.WriteLine("Inside DisplayInterface.");
            vehicle.Display();
        }

        public static void DisplayParent(BaseVehicle baseVehicle)
        {
            Console.WriteLine("Base Parent Display");
            baseVehicle.Display();
            Console.WriteLine("Now going to do display 2");
            baseVehicle.Display2();
            Console.WriteLine("This is the type on this object: {0}", baseVehicle.GetType().ToString());
        }

        public static void DisplayNewSection(string line)
        {
            Console.WriteLine(" ");
            Console.WriteLine(line);
            Console.WriteLine("------------");
        }
    }
}
