/* using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace SkriptPrototyp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SkriptDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SkriptDBContext>>()))
            {
                // Look for any scripts.
                if (context.Skripte.Any())
                {
                    return;   // DB has been seeded
                }

                context.Skripte.AddRange(
                    new Skript
                    {
                        Name = "Skript 1",
                        Displayname = "Uno",
                        Discription = "Das erste Skript",
                        Status = "Fine"
                    },

                    new Skript
                    {
                        Name = "Skript 2",
                        Displayname = "zwei",
                        Discription = "Das zweite Skript",
                        Status = "Fine"
                    },

                    new Skript
                    {
                        Name = "Skript 3",
                        Displayname = "Blubber",
                        Discription = "Das dritte Skript",
                        Status = "Fine"
                    },

                    new Skript
                    {
                        Name = "Skript 4",
                        Displayname = "last",
                        Discription = "Das vierte Skript",
                        Status = "False"
                    }
                );
                context.SaveChanges();
            }


        }
    }
    */