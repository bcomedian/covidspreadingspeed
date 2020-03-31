using System;
using System.Collections.Generic;

namespace CovidSpreadingSpeed.WebService.Models
{
    public class CountryVirusHistory
    {
        /// <summary>
        /// Country name
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// The date of the first occurance
        /// </summary>
        public DateTime FirstOccured { get; set; }

        /// <summary>
        /// Infected, deaths and recovered by days
        /// </summary>
        public Dictionary<DateTime, VirusImpact> ImpactByDays { get;set; }
    }
}
