using AB_Education.Data;
using AB_Education.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AB_Education.Services
{
   public interface IIdentityService
    {
        Task CreateRootAccountAsync();
        //IEnumerable<ApplicationUser> GetAllUsers();

        //IEnumerable<IdentityRole> GetAllRoles();

        //Task<IEnumerable<UserViewModel>> GetAllUsersWithRolesAsync();
        
    }
}
