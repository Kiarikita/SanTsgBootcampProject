using HotelSearch.Domain.Users;
using System.Collections.Generic;

namespace HotelSearch.Data.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        List<User> GetAll(int userId);
    }
}
