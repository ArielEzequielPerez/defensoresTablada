using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace defensoresTablada.Data
{
    public static class ContextSeed
    {

        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("Administrador"));
            await roleManager.CreateAsync(new IdentityRole("Profesional"));
            await roleManager.CreateAsync(new IdentityRole("Cliente"));

             
            
        }
    }
}
    /*
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole("Admnistrador"));
            await roleManager.CreateAsync(new IdentityRole("Profesional"));
            await roleManager.CreateAsync(new IdentityRole("Cliente"));
        }
    }*/

