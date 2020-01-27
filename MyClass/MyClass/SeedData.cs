using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyClass.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyClass
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var provider = scope.ServiceProvider;
                var context = provider.GetRequiredService<MyClassDBContext>();
                var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

                // automigration 
                context.Database.Migrate();
                AddRoles(roleManager, "Student");
                AddRoles(roleManager, "Teacher");
            }
        }

        private static void AddRoles(RoleManager<IdentityRole> roleManager, string name)
        {
            var roleExist = roleManager.RoleExistsAsync(name).Result;
            if (!roleExist)
            {
                //create the roles and seed them to the database
                roleManager.CreateAsync(new IdentityRole(name)).GetAwaiter().GetResult();
            }
        }

    }
}
