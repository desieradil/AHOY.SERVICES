using Ahoy.Domain.Base;
using Ahoy.Domain.Interfaces.Hotels;
using Ahoy.Domain.Models.Hotels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahoy.API.Controllers.Hotels
{

    [Route("api/v1/hotel")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepo;

        public HotelController(IHotelRepository hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        [Route("list")]
        [HttpGet]
        public async Task<IActionResult> GetHotelList()
        {

            HotelList responseBase = null;
            try
            {

                responseBase = await _hotelRepo.HotelList();
            }
            catch (Exception e)
            {

            }
            return Ok(responseBase);
        }

        [Route("details")]
        [HttpGet]
        public async Task<IActionResult> GetHotelDetails()
        {

            MultiResponse multiResponse = null;
            try
            {

                multiResponse = await _hotelRepo.SearchHotel();
            }
            catch (Exception e)
            {

            }
            return Ok(multiResponse);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateBooking([FromBody] Booking booking)
        {
            if (booking == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ResponseBase responseBase = null;
            try
            {

                responseBase = await _hotelRepo.BookingHotel(booking);

            }
            catch (Exception ex)
            {

            }
            return Ok(responseBase);
        }


    }
}
