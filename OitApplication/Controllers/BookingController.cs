using Microsoft.AspNetCore.Mvc;
using OitApplication.Domain.Entities;
using OitApplication.Domain.Repositories;
using OitApplication.Models;

namespace OitApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingController(
            IBookingRepository bookingRepository) 
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public IEnumerable<BookingInfo> GetBookingInfos() 
        {
            return _bookingRepository.GetBookingInfos();
        }

        [HttpGet("{id}")]
        public ActionResult<BookingInfo> GetBookingInfo(int id) 
        {
            var bookingInfo = _bookingRepository.GetBookingInfo(id);
            if (bookingInfo == null) 
            {
                return NotFound();
            }
            return bookingInfo;
        }

        [HttpPost]
        public IActionResult AddBookingInfo(BookingModel bookingInfo) 
        {
            var newBookingInfo = new BookingInfo
            {
                Name = bookingInfo.Name,
                Description = bookingInfo.Description
            };
            _bookingRepository.AddBookingInfo(newBookingInfo);
            return Ok("success");
        }
    }
}
