using ConsumirAPI.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace ConsumirAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CountryController : ControllerBase
    {
        private readonly ICountryApiService _countryApiService;

        public CountryController(ICountryApiService countryApiService)
        {
            _countryApiService = countryApiService;
        }

        /// <summary>
        /// Get all the Info about a country
        /// </summary>
        /// <param name="country"> Write the name of the Country you want</param>
        /// <returns></returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Models.Country>))]
        [HttpGet]
        public async Task<IActionResult> get([FromQuery][Required]string country)
        {
            var resultado = await _countryApiService.getCountry(country);
            return Ok(resultado);
        }
    }
}
