using CovidSpreadingSpeed.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidSpreadingSpeed.WebService.DataProviders
{
    /// <summary>
    /// Data provider abstraction which provides data about COVID
    /// </summary>
    interface ICovidDataProvider
    {
        /// <summary>
        /// Asynchronously gets list of all countries being impacted
        /// </summary>
        Task<List<string>> GetAllImpactedCountriesAsync();

        /// <summary>
        /// Asynchronously gets impact history by specific country
        /// </summary>
        Task<CountryVirusHistory> GetImpactHistory(string country);
    }
}
