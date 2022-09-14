using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wba.Films.Web.Data;
using System;
using System.Linq;

namespace Wba.Films.Web.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WbaFilmsWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WbaFilmsWebContext>>()))
            {
                if (context.Film.Any())
                {
                    return;
                }

                context.Film.AddRange(
                    new Film
                    {
                        Titel = "When Harry Met Sally",
                        Uitgiftedatum = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Prijs = 7.99M,
                        Rating = "R"
                    },

                    new Film
                    {
                        Titel = "Ghostbusters ",
                        Uitgiftedatum = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Prijs = 8.99M,
                        Rating = "R"
                    },

                    new Film
                    {
                        Titel = "Ghostbusters 2",
                        Uitgiftedatum = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Prijs = 9.99M,
                        Rating = "R"
                    },

                    new Film
                    {
                        Titel = "Rio Bravo",
                        Uitgiftedatum = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Prijs = 3.99M,
                        Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }

    }
}
