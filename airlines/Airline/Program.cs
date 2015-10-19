using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // init
            var planes = new List<IPlane>()
            {
                new VipPlane(1800.1)
                {
                    Name = "VIP 1",
                    Volume = 100,
                    Carrying = 200,
                    Range = 4000,
                },
                new VipPlane(1900)
                {
                    Name = "VIP 2",
                    Volume = 120,
                    Carrying = 280,
                    Range = 5000.55,
                },
                new EconomPlane(1200.5)
                {
                    Name = "Econom 1",
                    Volume = 200,
                    Carrying = 560,
                    Range = 5000.55,
                },
                new EconomPlane(980)
                {
                    Name = "Econom 2",
                    Volume = 100,
                    Carrying = 50,
                    Range = 1400.1,
                },
                new EconomPlane(1100.95)
                {
                    Name = "Econom 3",
                    Volume = 120,
                    Carrying = 90,
                    Range = 2000,
                },
            };

            // create company
            var airlineCompany = new AirlineCompany(planes);

            // get planes
            Console.WriteLine("planes:");
            foreach (var plane in airlineCompany.GetPlanes())
            {
                Console.WriteLine(plane.Name + " - " + plane.Volume + " - " + plane.Carrying + " - " + plane.Range + " - " + plane.GetFuelConsumption());
            }
            Console.WriteLine();

            // get total volume
            var totalVolume = airlineCompany.GetTotalVolume();
            Console.WriteLine("totalVolume: " + totalVolume);
            Console.WriteLine();

            // get total carrying
            var totalCarrying = airlineCompany.GetTotalCarrying();
            Console.WriteLine("totalCarrying: " + totalCarrying);
            Console.WriteLine();

            // get planes ordered by range
            var planesOrderedByRange = airlineCompany.GetPlanesOrderedByRange();
            Console.WriteLine("planes ordered by range:");
            for (int i = 0; i < planesOrderedByRange.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + planesOrderedByRange[i].Name + " - " + planesOrderedByRange[i].Range);
            }
            Console.WriteLine();

            // search planes by fuel consumption
            Console.WriteLine("Please enter values for search");
            Console.Write("min fuel consumption: ");
            var minFuelConsumption = Convert.ToDouble(Console.ReadLine());
            Console.Write("max fuel consumption: ");
            var maxFuelConsumption = Convert.ToDouble(Console.ReadLine());
            var foundPlanes = airlineCompany.SearchPlanesByFuelConsumption(minFuelConsumption, maxFuelConsumption);
            if (foundPlanes.Count > 0)
            {
                Console.WriteLine("found planes:");
                for (int i = 0; i < foundPlanes.Count; i++)
                {
                    Console.WriteLine((i + 1) + ": " + foundPlanes[i].Name + " - " + foundPlanes[i].GetFuelConsumption());
                }
            }
            else
            {
                Console.WriteLine("No planes found.");
            }

            Console.ReadLine();
        }
    }
}