using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public interface IPlane
    {
        string Name { get; set; }

        int Volume { get; set; }
        double Carrying { get; set; }
        double Range { get; set; }

        double GetFuelConsumption();
    }
}
