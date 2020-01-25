using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSystem.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "John";
        private const string adminPassword = "Secret123$";

        private const string managerUser = "Paul";
        private const string managerPassword = "Secret456$";

        private const string adminRoleName = "Admin";
        private const string managerRoleName = "Manager";

        public static async void EnsurePopulated(IApplicationBuilder app) // This method will ensure that the DB is populated with data
        {
            // Create the role
            RoleManager<IdentityRole> roleManager = app.ApplicationServices
                .GetRequiredService<RoleManager<IdentityRole>>();

            // Create admin role
            IdentityRole adminRole = await roleManager.FindByNameAsync(adminRoleName);

            if (adminRole == null)
            {
                adminRole = new IdentityRole(adminRoleName);
                await roleManager.CreateAsync(adminRole);
            }

            // Create admin user
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .GetRequiredService<UserManager<IdentityUser>>();

            IdentityUser user = await userManager.FindByIdAsync(adminUser); // Await requires async method

            if (user == null)
            {
                user = new IdentityUser(adminUser);
                await userManager.CreateAsync(user, adminPassword);
                await userManager.AddToRoleAsync(user, adminRoleName);
            }
            else
            {
                if (!(await userManager.IsInRoleAsync(user, adminRoleName))) // User already exists
                {
                    await userManager.AddToRoleAsync(user, adminRoleName);
                }
            }

            // Create manager role
            IdentityRole managerRole = await roleManager.FindByNameAsync(managerRoleName);

            if (managerRole == null)
            {
                managerRole = new IdentityRole(managerRoleName);
                await roleManager.CreateAsync(managerRole);
            }

            // Create manager user
            IdentityUser managerUserIdentity = await userManager.FindByNameAsync(managerUser);

            if (managerUserIdentity == null)
            {
                managerUserIdentity = new IdentityUser(managerUser);
                await userManager.CreateAsync(managerUserIdentity, managerPassword);
                await userManager.AddToRoleAsync(managerUserIdentity, managerRoleName);
            }
            else
            {
                if (!(await userManager.IsInRoleAsync(managerUserIdentity, managerRoleName)))
                {
                    await userManager.AddToRoleAsync(managerUserIdentity, managerRoleName);
                }
            }
        }
    }
}
