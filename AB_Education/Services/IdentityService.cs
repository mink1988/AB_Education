using AB_Education.Data;
using AB_Education.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AB_Education.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        //public async Task<IdentityResult> CreateNewUserAsync(ApplicationUser user, string password)
        //{
        //    return await _userManager.CreateAsync(user, password);
        //}

        public async Task CreateRootAccountAsync()
        {
            if (!_userManager.Users.Any())
            {
                var user = new ApplicationUser()
                {
                    UserName = "admin@domain.com",
                    Email = "admin@domain.com",
                    FirstName = "Admin",
                    LastName = "Account"
                };
                var result = await _userManager.CreateAsync(user, "BytMig123!");

                if (result.Succeeded)
                {
                    if (!_roleManager.Roles.Any())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("Admin"));
                        await _roleManager.CreateAsync(new IdentityRole("Teacher"));
                        await _roleManager.CreateAsync(new IdentityRole("Student"));
                    }

                    await _userManager.AddToRoleAsync(user, "Admin");
                }


            }
        }

       




        //public IEnumerable<IdentityRole> GetAllRoles()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<IdentityRole> GetAllRoles()
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<IdentityRole> GetAllRoles()
        //{
        //    return _roleManager.Roles;
        //}

        //public IEnumerable<ApplicationUser> GetAllUsers()
        //{
        //    return _userManager.Users;
        //}

        //public async Task<IEnumerable<UserViewModel>> GetAllUsersWithRolesAsync()
        //{
        //    var users = GetAllUsers();
        //    var userlist = new List<UserViewModel>();

        //    foreach (var user in users)
        //    {
        //        var roles = await _userManager.GetRolesAsync(user);
        //        var role = roles.FirstOrDefault();

        //        userlist.Add(new UserViewModel
        //        {

        //            FirstName = user.FirstName,
        //            LastName = user.LastName,
        //            Email = user.Email,
        //            Role = role
        //        });
        //    }

        //    return userlist;

        //}

    }
}

