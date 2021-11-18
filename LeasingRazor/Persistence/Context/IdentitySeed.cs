using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeasingRazor.Domain;
using Microsoft.AspNetCore.Identity;

namespace LeasingRazor.Persistence.Context
{
    public class IdentitySeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Domain.EnumInEntity.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Domain.EnumInEntity.Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Domain.EnumInEntity.Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Domain.EnumInEntity.Roles.Basic.ToString()));
        }
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "sutanto.gasali@gmail.com",
                FirstName = "Sutanto",
                LastName = "Gasali",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Domain.EnumInEntity.Roles.Basic.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Domain.EnumInEntity.Roles.Moderator.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Domain.EnumInEntity.Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Domain.EnumInEntity.Roles.SuperAdmin.ToString());
                }

            }
        }
        public static async Task SeedBasicUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new ApplicationUser
            {
                UserName = "basic",
                Email = "basic@gmail.com",
                FirstName = "John",
                LastName = "Doe",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Pa$$word.");
                    await userManager.AddToRoleAsync(defaultUser, Domain.EnumInEntity.Roles.Basic.ToString());
                }

            }
        }
    }
}
