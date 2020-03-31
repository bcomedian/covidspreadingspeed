using CovidSpreadingSpeed.WebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidSpreadingSpeed.WebService.DataProviders
{
    /// <inheritdoc />
    public class Covid19ApiComDataProvider : ICovidDataProvider
    {
        /// <inheritdoc />
        public Task<List<string>> GetAllImpactedCountriesAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task<CountryVirusHistory> GetImpactHistory(string country)
        {
            throw new NotImplementedException();
        }
    }
}
