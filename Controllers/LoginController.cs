using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using tl2_tp6_2024_cristianlana12.repositories;

namespace tl2_tp6_2024_cristianlana12.Controllers
{
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly IUserRepository _inMemoryUserRepository;
        public LoginController(IUserRepository inMemoryUserRepository){
            _inMemoryUserRepository = inMemoryUserRepository;
        }

        [HttpGet]
        public IActionResult Index(){
            return View(
                new 
            )
        }
    }
}