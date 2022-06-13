using HotelSearch.Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelSearch.Data
{
    public class HotelSearchDbContext : DbContext
    {
        public HotelSearchDbContext(DbContextOptions<HotelSearchDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
