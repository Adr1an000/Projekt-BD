using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InformacjeTurystyczne.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public ViewResult Index()
        {
            return View(_roleManager.Roles);
        }

        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([Required] string roleName)
        {
            if(ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(roleName));

                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ResultErrors(result);
                }
            }

            return View(roleName);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            if(role!= null)
            {
                var result = await _roleManager.DeleteAsync(role);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ResultErrors(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "Nie znaleziono roli.");
            }

            return View("Index", _roleManager.Roles);
        }

        private void ResultErrors(IdentityResult result)
        {
            foreach (var e in result.Errors)
            {
                ModelState.AddModelError("", e.Description);
            }
        }
    }
}