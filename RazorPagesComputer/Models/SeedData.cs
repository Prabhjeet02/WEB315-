using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace RazorPagesComputer.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesComputerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesComputerContext>>()))
            {
                // Look for any Computer.
                if (context.Computer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Computer.AddRange(
                    new Computer
                    {
                        Company = "hp",
                        ReleaseDate = DateTime.Parse("2005-08-22"),
                        Processor = "intel core i2",
                        Price = 285.25M
                    },

                    new Computer
                    {
                        Company = "asus",
                        ReleaseDate = DateTime.Parse("2017-07-20"),
                        Processor = "intel core i3",
                        Price = 400.00M
                    },

                    new Computer
                    {
                        Company = "Dell",
                        ReleaseDate = DateTime.Parse("2006-01-18"),
                        Processor = "intel core i2",
                        Price = 250.00M
                    },

                    new Computer
                    {
                        Company = "hp",
                        ReleaseDate = DateTime.Parse("2014-06-11"),
                        Processor = "intel core i4",
                        Price = 425.00M
                    },
                    new Computer
                    {
                        Company = "hp",
                        ReleaseDate = DateTime.Parse("2018-06-11"),
                        Processor = "intel core i5",
                        Price = 500.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}