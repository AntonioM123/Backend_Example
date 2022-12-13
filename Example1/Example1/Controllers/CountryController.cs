using Example1.Data;
using Example1.Services.Country;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountry _countryService;

        public CountryController(ICountry countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("id")]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            try
            {
                return Ok(await _countryService.GetCountry(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet()]
        public async Task<ActionResult<IList<CountryDto>>> GetCountries()
        {
            try
            {
                return Ok(await _countryService.GetCountries());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public async Task<ActionResult<CountryDto>> CreateCountry(CountryDto dto)
        {
            try
            {
                return Ok(await _countryService.CreateCountry(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]

        public async Task<ActionResult<CountryDto>> UpdateCountry(CountryDto dto)
        {
            try
            {
                return Ok(await _countryService.UpdateCountry(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            };
        }

        [HttpDelete]

        public async Task<ActionResult<CountryDto>> DeleteCountry(int id)
        {
            try
            {
                return Ok(await _countryService.DeleteCountry(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
