using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models;
using InformacjeTurystyczne.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if(user != null) 
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Nazwa użytkownika lub hasło nie są poprawne.");

            return View(loginVM);
        }

        // GET: /<controller>/
        public IActionResult Register()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginVM loginVM)
        {
            if(ModelState.IsValid)
            {
                var user = new AppUser() { UserName = loginVM.UserName, Email = loginVM.Email };
                var result = await _userManager.CreateAsync(user, loginVM.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(loginVM);
        }

        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}