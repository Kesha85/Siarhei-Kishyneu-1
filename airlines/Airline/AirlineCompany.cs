using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class AirlineCompany
    {
        private List<IPlane> _planes;

        public AirlineCompany(List<IPlane> planes)
        {
            _planes = planes;
        }

        public List<IPlane> GetPlanes()
        {
            return _planes;
        }

        public int GetTotalVolume()
        {
            var result = 0;

            foreach (var plane in _planes)
            {
                result += plane.Volume;
            }

            return result;
        }

        public double GetTotalCarrying()
        {
            var result = 0.0;

            foreach (var plane in _planes)
            {
                result += plane.Carrying;
            }

            return result;
        }

        public List<IPlane> GetPlanesOrderedByRange()
        {
            return _planes.OrderBy(x => x.Range).ToList(); // we can use not Linq order
        }

        public List<IPlane> SearchPlanesByFuelConsumption(double minFuelConsumption, double maxFuelConsumption)
        {
            // solution using Linq
            // var linqList = _planes.Where(x => x.GetFuelConsumption() >= minFuelConsumption && x.GetFuelConsumption() <= maxFuelConsumption).ToList();

            var list = new List<IPlane>();

            foreach (var plane in _planes)
            {
                var planeFuelConsumption = plane.GetFuelConsumption();

                if (planeFuelConsumption >= minFuelConsumption && planeFuelConsumption <= maxFuelConsumption)
                {
                    list.Add(plane);
                }
            }

            return list;
        }
    }
}
