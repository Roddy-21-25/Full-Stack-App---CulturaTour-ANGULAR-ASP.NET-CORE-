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
    public class HolidaysController : ControllerBase
    {
        private readonly IHolidaysApiService  _holidaysApiService;

        public HolidaysController(IHolidaysApiService holidaysApiService)
        {
            _holidaysApiService = holidaysApiService;
        }

        /// <summary>
        /// Get info of the Holidays of a Country
        /// </summary>
        /// <param name="ISO2">Is a Unit ID for to Find a Country</param>
        /// <param name="year">Select the Year for this country</param>
        /// <param name="type">
        /// Here you can choose the Type of the Holiday.
        /// There is the list:
        /// major_holiday - combination of public_holiday, national_holiday, and federal_holiday.
        /// public_holiday
        /// observance
        /// national_holiday
        /// federal_holiday(US only)
        /// season
        /// state_holiday
        /// optional_holiday
        /// clock_change_daylight_saving_time
        /// local_holiday
        /// united_nations_observance
        /// observance_christian
        /// bank_holiday
        /// common_local_holiday
        /// national_holiday_christian
        /// christian
        /// observance_hebrew
        /// jewish_holiday
        /// muslim
        /// hindu_holiday
        /// restricted_holiday
        /// official_holiday
        /// national_holiday_orthodox
        /// local_observance
        /// </param>
        /// <returns></returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Models.Holidays>))]
        [HttpGet]
        public async Task<IActionResult> get([FromQuery][Required]string ISO2, [FromQuery][Required]int year, [FromQuery][Required]string type)
        {
            var resultado = await _holidaysApiService.getHolidays(ISO2, year, type);
            return Ok(resultado);
        }
    }
}
