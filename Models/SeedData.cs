using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyScriptureJournal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
        public static class SeedData
        {
            public static void Initialize(IServiceProvider serviceProvider)
            {
                using (var context = new MyScriptureJournalContext(
                    serviceProvider.GetRequiredService<
                        DbContextOptions<MyScriptureJournalContext>>()))
                {
                    // Look for any Scriptures.
                    if (context.Scripture.Any())
                    {
                        return;   // DB has been seeded
                    }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Canon = "The Book of Mormon",
                        Book = "Alma",
                        Chapter = "36",
                        Verses = "14-17",
                        CreatedDate = DateTime.Now,
                        Note = "I really love hearing about the change of heart that Alma had to go through"
                    },

                    new Scripture
                    {
                        Canon = "The New Testament",
                        Book = "Romans",
                        Chapter = "1",
                        Verses = "16",
                        CreatedDate = DateTime.Now,
                        Note = "We should never be ashamed for what we believe in"
                    },

                    new Scripture
                    {
                        Canon = "Doctrine and Covenants",
                        Book = "D&C",
                        Chapter = "76",
                        Verses = "22-24",
                        CreatedDate = DateTime.Now,
                        Note = "We should always remember that the Savior lives and has been resurrected"
                    }

                );
                    context.SaveChanges();
                }
            }
        }
}
