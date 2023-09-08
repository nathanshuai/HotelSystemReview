using HotelSystemReview0.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelSystemReview0.Data
{
    public class HotelSystemReview0Context: DbContext
    {
        public HotelSystemReview0Context(DbContextOptions<HotelSystemReview0Context> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; } = default!;
        public DbSet<Room> Room { get; set; } = default!;
    }
}
