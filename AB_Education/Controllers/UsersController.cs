using AB_Education.Data;
using AB_Education.Models;
using AB_Education.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_Education.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Admins = await _userManager.GetUsersInRoleAsync("Admin");
            ViewBag.Users = await _userManager.GetUsersInRoleAsync("Users");
            ViewBag.Teachers = await _userManager.GetUsersInRoleAsync("Teacher");
            ViewBag.Students = await _userManager.GetUsersInRoleAsync("Student");

            return View();
        }
        public IActionResult Create()
        {
            ViewBag.Roles = _roleManager.Roles;   
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName
                };

                var result = await _userManager.CreateAsync(user, "BytMig123!");

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, model.Role);
                    return RedirectToAction("Index", "Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View();
        }
            
    }
}
