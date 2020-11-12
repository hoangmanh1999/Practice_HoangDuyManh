using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Practice.Models
{
    public class SeedData
    {
        public static void SeedEmployee(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                        new Employee
                        {
                            Name = "Manh",
                            Address = "Ha Noi",
                            Phone = "111111111",
                            Email = "manh@gmail.com",
                            Year = new DateTime(1999,10,22)
                        },
                        new Employee
                        {
                            Name = "Manh2",
                            Address = "Ha Noi",
                            Phone = "222222222",
                            Email = "manh2@gmail.com",
                            Year = new DateTime(1999, 10, 22)
                        },
                        new Employee
                        {
                            Name = "Manh3",
                            Address = "Ha Noi",
                            Phone = "33333333",
                            Email = "manh3@gmail.com",
                            Year = new DateTime(1999, 10, 22)
                        },
                        new Employee
                        {
                            Name = "Manh4",
                            Address = "Ha Noi",
                            Phone = "44444444",
                            Email = "manh4@gmail.com",
                            Year = new DateTime(1999, 10, 22)
                        },
                        new Employee
                        {
                            Name = "Manh5",
                            Address = "Ha Noi",
                            Phone = "555555555",
                            Email = "manh5@gmail.com",
                            Year = new DateTime(1999, 10, 22)
                        }
                    );
                context.SaveChanges();
            }
        }
    }
}
