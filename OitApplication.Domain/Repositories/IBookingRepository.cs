using OitApplication.Domain.Entities;

namespace OitApplication.Domain.Repositories
{
    public interface IBookingRepository
    {
        void AddBookingInfo(BookingInfo bookingInfo);
        BookingInfo? GetBookingInfo(int id);
        IEnumerable<BookingInfo> GetBookingInfos();
    }
}
