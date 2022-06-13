using HotelSearch.Application.Interfaces;
using HotelSearch.Application.Models;
using HotelSearch.Data;
using HotelSearch.Domain.Users;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HotelSearch.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IEmailService _emailService;
        private readonly ILogger<UserService> _logger;

        public UserService(IUnitOfWork unitOfWork, IEmailService emailService, ILogger<UserService> logger)
        {
            _unitOfWork = unitOfWork;
            _emailService = emailService;
            _logger = logger;
        }

        public async Task CreateUser(User user)
        {
            _unitOfWork.Users.Add(user);

            MailRequest mail = new MailRequest()
            {
                Body = "Kaydiniz basariyla alinmistir",
                Subject = "HotelSearch Kayit Onayi",
                ToEmail = user.Email
            };

            await _emailService.SendEmailAsync(mail);
            _unitOfWork.Complete();
            _logger.LogInformation("Yeni kullanıcı kaydi eklendi, eklenilen kayit {@user}", user);

        }
    }
}
