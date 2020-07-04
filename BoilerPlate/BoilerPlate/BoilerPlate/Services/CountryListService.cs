using BoilerPlates.Global;
using BoilerPlates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoilerPlate.Services
{
    class CountryListService : ICountryListService
    {
        public async Task<GenericResponse<List<CountryResponse>>> getCountriesList()
        {
            var uri = new Uri(string.Format(BaseUrl.baseUrl + "/countries", string.Empty));

            var resposne = await ApiService.GetRequest<GenericResponse<List<CountryResponse>>>(uri);
            return resposne;
        }
    }
}
