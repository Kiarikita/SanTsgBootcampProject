using HotelSearch.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace HotelSearch.Data
{
    public class HotelSearchDbContext : DbContext
    {
        public HotelSearchDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
