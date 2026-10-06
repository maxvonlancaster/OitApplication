using OitApplication.Domain.Entities;

namespace OitApplication.Domain.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        //private readonly List<BookingInfo> _bookingInfos =
        //    new List<BookingInfo>() {
        //        new BookingInfo()
        //        {
        //            Id = 1,
        //            Name = "Booking 1",
        //            Description = "Description for Booking 1",
        //            ServiceType = "Service Type 1"
        //        },
        //        new BookingInfo()
        //        {
        //            Id = 2,
        //            Name = "Booking 2",
        //            Description = "Description for Booking 2",
        //            ServiceType = "Service Type 2"
        //        },
        //        new BookingInfo()
        //        {
        //            Id = 3,
        //            Name = "Booking 3",
        //            Description = "Description for Booking 3",
        //            ServiceType = "Service Type 3"
        //        }
        //    };

        private readonly BookingContext _bookingContext;

        public BookingRepository(BookingContext context)
        {
            _bookingContext = context;
        }

        public IEnumerable<BookingInfo> GetBookingInfos()
        {
            return _bookingContext.BookingInfos.ToList();
        }

        public BookingInfo? GetBookingInfo(int id)
        {
            return _bookingContext.BookingInfos
                .FirstOrDefault(b => b.Id == id);
        }

        public void AddBookingInfo(BookingInfo bookingInfo)
        {
            _bookingContext.BookingInfos.Add(bookingInfo);
            _bookingContext.SaveChanges();
        }
    }
}
