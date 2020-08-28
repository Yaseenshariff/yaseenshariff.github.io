using SpanishFootballLeague.Interfaces;
using SpanishFootballLeague.Models;
using System.Web.Mvc;

namespace SpanishFootballLeague.Controllers
{
    public class LoginController : Controller
    {
        private IUserRepository _userRepository;
        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                UserDto user = _userRepository.isValidUser(loginViewModel);
                if(user != null)
                {
                    return RedirectToAction("Index", "Home");
                }    
            }
            ViewBag.InvalidAttempt = "Username or password is invalid";
            return View(loginViewModel);
        }
    }
}