using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    internal interface IVehicle
    {
        public double GetMPG { get; }

        public bool IsPreOwned { get; }

        public string GetMakeModule { get; }

        public void Display();
    }
}
