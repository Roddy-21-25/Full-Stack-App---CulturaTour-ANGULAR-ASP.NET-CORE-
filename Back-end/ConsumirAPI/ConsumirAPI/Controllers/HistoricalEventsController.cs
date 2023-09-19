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
    public class HistoricalEventsController : ControllerBase
    {
        private readonly IHistoricalEventsApiService  _historicalEventsApiService;

        public HistoricalEventsController(IHistoricalEventsApiService historicalEventsApiService)
        {
            _historicalEventsApiService = historicalEventsApiService;
        }

        /// <summary>
        /// Get info of the most important Historical Events of a Country
        /// </summary>
        /// <param name="country">Write the name of the Country you want</param>
        /// <returns></returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<Models.HistoricalEvents>))]
        [HttpGet]
        public async Task<IActionResult> get([FromQuery][Required]string country)
        {
            var resultado = await _historicalEventsApiService.getHistoricalEvents(country);
            return Ok(resultado);
        }
    }
}
