using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidSpreadingSpeed.WebService.Models
{
    interface CountryVirusHistory
    {
        /// <summary>
        /// Country name
        /// </summary>
        string Country { get; set; }

        /// <summary>
        /// The date of the first occurance
        /// </summary>
        DateTime FirstOccured { get; set; }

        /// <summary>
        /// Infected, deaths and recovered by days
        /// </summary>
        Dictionary<DateTime, VirusImpact> ImpactByDays { get;set; }
    }
}
