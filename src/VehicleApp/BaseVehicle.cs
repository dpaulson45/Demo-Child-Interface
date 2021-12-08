using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal class BaseVehicle : IVehicle
    {
        protected string module;

        protected string make;

        protected double mpg;

        protected bool preOwned;

        public BaseVehicle(string Make, string Module, double MPG, bool IsPreOwned = true)
        {
            this.make = Make;
            this.module = Module;
            this.mpg = MPG;
            this.preOwned = IsPreOwned;
        }

        public string GetMakeModule
        {
            get { return string.Format("Module: {0} Make: {1}", this.module, this.make); }
        }

        public double GetMPG
        {
           get { return this.mpg; }
        }

        public bool IsPreOwned
        { 
            get { return this.preOwned; } 
        }

        public virtual void Display()
        {
            Console.WriteLine("This is the base vehicle information.");
            Console.WriteLine(GetMakeModule);
            Console.WriteLine("MPG: {0}", GetMPG);
            Console.WriteLine("Vehicle is{0}preowned.", (IsPreOwned ? " " : " NOT "));
        }

        public void Display2()
        {
            Console.WriteLine("This is the display 2 on base vehicle information.");
        }
    }
}
