using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebMVC.Data;
using System;
using System.Linq;

namespace WebMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebMVCContext>>()))
            {
                // Look for any movies.
                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context.Employee.AddRange(
                    new Employee
                    {
                        EmployeeId = "MVC001",
                         EmployeeName = "Trần Văn A",
                        Department = "HR",
                        Salary = 1000
                    },
                     new Employee
                     {
                         EmployeeId = "MVC002",
                         EmployeeName = "Trần Nhật Tân",
                         Department = "SC",
                         Salary = 1050
                     },
                      new Employee
                      {
                          EmployeeId = "MVC003",
                          EmployeeName = "Nguyễn Văn A",
                          Department = "HR",
                          Salary = 2000
                      },
                       new Employee
                       {
                           EmployeeId = "MVC004",
                           EmployeeName = "Trần Bình Dương",
                           Department = "MD",
                           Salary = 1111
                       }


                );
                context.SaveChanges();
            }
        }
    }
}
