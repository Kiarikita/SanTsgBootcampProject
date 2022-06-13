using HotelSearch.Application.Models;
using System.Threading.Tasks;

namespace HotelSearch.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
