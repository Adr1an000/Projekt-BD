using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            LoginVM loginVM = new LoginVM
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()

            };

            return View(loginVM);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                /*
                var errors = ModelState.Select(x => x.Value.Errors)
                          .Where(y => y.Count > 0)
                          .ToList();
                          */

                if (loginVM.UserName == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić nazwę użytkownika!");
                }

                if (loginVM.Password == null)
                {
                    ModelState.AddModelError(string.Empty, "Musisz uzupełnić hasło!");
                }

                return View(loginVM);
            }

            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                if (result.Succeeded)
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
            if (ModelState.IsValid)
            {
                var user = new AppUser() { UserName = loginVM.UserName, Email = loginVM.Email };
                var result = await _userManager.CreateAsync(user, loginVM.Password);

                if (result.Succeeded)
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

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var url = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, url);

            return new ChallengeResult(provider, properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            LoginVM loginVM = new LoginVM
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteUrl != null)
            {
                ModelState.AddModelError(string.Empty, $"Błąd ze strony zewnętrznych usług logowania: {remoteUrl}");

                return View("Login", loginVM);
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();

            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Błąd podczas odczytywania informacji od dostawcy zewnętrznych usług logowania.");

                return View("Login", loginVM);
            }


            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            //  string[] userInfo = { info.Principal.FindFirst(ClaimTypes.Name).Value, info.Principal.FindFirst(ClaimTypes.Email).Value };

            if (result.Succeeded)
            {
                //return View(userInfo);
                return LocalRedirect(returnUrl);
            }
            else
            {

                var user = new AppUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = info.Principal.FindFirst(ClaimTypes.Email).Value,
                };

                var identResult = await _userManager.CreateAsync(user);

                if (identResult.Succeeded)
                {
                    identResult = await _userManager.AddLoginAsync(user, info);

                    if (identResult.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, false);

                        return LocalRedirect(returnUrl);
                    }
                }


                return AccessDenied();
            }
        }


    }
}