using Example1.Data;
using Example1.Services.Hotels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotel _hotelService;

        public HotelsController(IHotel hotelService)
        {
            _hotelService = hotelService;
        }


        [HttpGet("id")]
        public async Task<ActionResult<HotelDto>> GetHotel(int id)
        {
            try
            {
                return Ok(await _hotelService.GetHotel(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet()]
        public ActionResult<IList<HotelDto>> GetHotels()
        {
            try
            {
                return Ok(_hotelService.GetHotels());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPost]
        public async Task<ActionResult<HotelDto>> CreateHotel(HotelDto dto)
        {
            try
            {
                return Ok(await _hotelService.CreateHotel(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]

        public async Task<ActionResult<HotelDto>> UpdateHotel(HotelDto dto)
        {
            try
            {
                return Ok(await _hotelService.UpdateHotel(dto));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete]

        public async Task<ActionResult<HotelDto>> DeleteHotel(int id)
        {
            try
            {
                return Ok(await _hotelService.DeleteHotel(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}
