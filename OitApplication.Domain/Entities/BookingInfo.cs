using Microsoft.EntityFrameworkCore;

namespace OitApplication.Domain.Entities
{
    public class BookingInfo
    {
        //[PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? ServiceType { get; set; }
    }
}
