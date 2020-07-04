using BoilerPlate.Services;
using BoilerPlate.ViewModels.Base;
using BoilerPlates.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoilerPlate.ViewModels
{
   public class CountriesListViewModel :BaseViewModel
    {
        public List<CountryResponse> CountryList { get; set; }
        ICountryListService _countryListService;
        public CountriesListViewModel()
        {
            _countryListService = ViewModelLocator.Resolve<ICountryListService>();
            GetCountriesList();
        }


        async void GetCountriesList()
        {
            var response = await _countryListService.getCountriesList();

            CountryList = response.Result;

            RaisePropertyChanged(() => CountryList);
        }
    }
}
