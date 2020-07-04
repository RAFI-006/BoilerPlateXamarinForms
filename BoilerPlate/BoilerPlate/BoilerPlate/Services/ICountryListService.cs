using BoilerPlates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoilerPlate.Services
{
    interface ICountryListService
    {
        Task<GenericResponse<List<CountryResponse>>> getCountriesList();
    }
}
