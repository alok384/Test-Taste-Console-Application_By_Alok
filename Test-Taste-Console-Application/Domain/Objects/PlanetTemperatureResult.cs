using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class PlanetTemperatureResult
    {
        public string name { get; set; }

        public bool isPlanet { get; set; }
        public ICollection<MoonDesp> moons { get; set; }
        public int MoonCount { get; set; }

        public double avgTemp { get; set; }
    }

    public class PlanetApiResponse
    {
        public List<PlanetTemperatureResult> bodies { get; set; }
    }
    public class PlanetTemperatureOutput
    {
        public string PlanetName { get; set; }

        public int MoonCount { get; set; }

        public double AverageTemperature { get; set; }
    }
    public class MoonDesp
    {
        public string moon { get; set; }
        public string rel { get; set; }
    }
}
