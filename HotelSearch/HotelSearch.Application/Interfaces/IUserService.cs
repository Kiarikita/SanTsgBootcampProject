using HotelSearch.Domain.Users;
using System.Threading.Tasks;

namespace HotelSearch.Application.Interfaces
{
    public interface IUserService
    {
        Task CreateUser(User user);
    }
}
