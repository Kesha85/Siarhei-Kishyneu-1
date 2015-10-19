using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class VipPlane : IPlane
    {
        private double _fuelConsumption;

        public VipPlane(double fuelConsumption)
        {
            _fuelConsumption = fuelConsumption;
        }

        public string Name { get; set; }

        public int Volume { get; set; }
        public double Carrying { get; set; }
        public double Range { get; set; }

        public double GetFuelConsumption()
        {
            return _fuelConsumption;
        }
    }
}
