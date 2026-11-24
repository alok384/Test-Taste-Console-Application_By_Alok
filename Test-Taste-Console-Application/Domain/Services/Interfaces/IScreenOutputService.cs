using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Taste_Console_Application.Domain.Objects;

namespace Test_Taste_Console_Application.Domain.Services.Interfaces
{
    internal interface IScreenOutputService
    {
        IEnumerable<PlanetTemperatureResult> GetPlanetMoonAvgTemp();
    }
}
