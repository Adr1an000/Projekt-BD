using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.Models;
using InformacjeTurystyczne.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers
{
    [Authorize]
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
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid)
            {
                /*
                var errors = ModelState.Select(x => x.Value.Errors)
                          .Where(y => y.Count > 0)
                          .ToList();
                          */

                if(loginVM.UserName == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić nazwę użytkownika!");
                }

                if(loginVM.Password == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić hasło!");
                }

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

            ModelState.AddModelError(string.Empty, "Nazwa użytkownika lub hasło nie są poprawne.");

            return View(loginVM);
        }

        // GET: /<controller>/
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View(new RegisterVM());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM loginVM)
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
            else
            {
                if (loginVM.UserName == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić nazwę użytkownika!");
                }

                if (loginVM.Password == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić hasło!");
                }

                if (loginVM.Email == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić adres email!");
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