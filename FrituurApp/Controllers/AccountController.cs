using Microsoft.AspNetCore.Mvc;
using FrituurApp.Models;
using Microsoft.AspNetCore.Identity;

namespace FrituurApp.Controllers
{       
    public class AccountController : Controller
    {   
        private readonly UserManager<Customer> _userManager;
        private readonly SignInManager<Customer> _signInManager;
        public AccountController(UserManager<Customer> userManager, 
            SignInManager<Customer> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);
                if(result.Succeeded)
                    return RedirectToAction("Index", "Home");
                ModelState.AddModelError("", "Invalid LogIn Attempt");
            }
            return View(login);
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");   
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register) 
        {
            if (ModelState.IsValid)
            {
                var user = new Customer()
                {
                    CustomerName = register.Name,
                    CustomerEmail = register.Email
                };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(user, register.Password, false, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("", err.Description);
                    }
                }
            }
            return View(register);
        }
    }
}
