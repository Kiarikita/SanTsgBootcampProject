using HotelSearch.Data.Repositories.Interfaces;
using HotelSearch.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelSearch.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(HotelSearchDbContext context) : base(context)
        {
        }

        public List<User> GetAll(int userId)
        {
            return _context.Users.Where(x => x.Id == userId).ToList();
        }
    }

    public class UserDapperRepository : Repository<User>, IUserRepository
    {
        public UserDapperRepository(HotelSearchDbContext context) : base(context)
        {
        }

        public List<User> GetAll(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
