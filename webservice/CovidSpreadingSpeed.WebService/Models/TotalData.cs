using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidSpreadingSpeed.WebService.Models
{
    public class TotalData
    {
        public List<string> Countries;
        public int DaysSinceFirstInfected;
        public VirusImpact VirusImpact;
    }
}
