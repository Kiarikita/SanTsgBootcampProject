using HotelSearch.Application.Interfaces;
using HotelSearch.Application.Models;
using HotelSearch.Data;
using HotelSearch.Data.Repositories.Interfaces;
using HotelSearch.Domain.Users;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSearch.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly HotelSearchDbContext _context;
        private readonly IUserRepository _userRepository;
        private readonly IEmailService _emailService;

        public UserController(HotelSearchDbContext context, IUserRepository userRepository, IEmailService emailService)
        {
            _context = context;
            _userRepository = userRepository;
            _emailService = emailService;
        }

        public IActionResult Index()
        {
            var data = _userRepository.GetAll();
            return View(data);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {

            if (ModelState.IsValid)
            {
                _context.Users.Add(user);

                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(user);
        }

        public IActionResult Edit(int? id)
        {
            if (id.GetValueOrDefault() == 0)
                return NotFound();

            var userDetails = _context.Users.FirstOrDefault(x => x.Id == id);

            if (userDetails == null)
                return NotFound();

            _context.Users.Update(userDetails);
            _context.SaveChanges();

            return View(userDetails);


        }

        [HttpPost()]
        public IActionResult Edit(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            _userRepository.Update(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            var userDetails = _context.Users.FirstOrDefault(x => x.Id == id);

            if (userDetails == null)
                return NotFound();
            return View(userDetails);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            var userDetails = _context.Users.FirstOrDefault(x => x.Id == id);

            if (userDetails == null)
                return NotFound();

            _context.Users.Remove(userDetails);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
