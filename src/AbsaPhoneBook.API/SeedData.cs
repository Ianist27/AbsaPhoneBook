using AbsaPhoneBook.Core.ProjectAggregate;
using AbsaPhoneBook.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AbsaPhoneBook.API
{
    public static class SeedData
    {
        public static readonly PhoneBook TestPhoneBook = new PhoneBook() { Name = "Tony Stark"};
        public static readonly Entry entry1 = new Entry
        {
            Name = "Captin America",
            PhoneNumber = "0123456781"
        };
        public static readonly Entry entry2 = new Entry
        {
            Name = "Tony Stark",
            PhoneNumber = "0123456782"
        };
        public static readonly Entry entry3 = new Entry
        {
            Name = "Thor",
            PhoneNumber = "0123456783"
        };

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>(), null))
            {
                // Look for any TODO items.
                if (dbContext.Entries.Any())
                {
                    return;   // DB has been seeded
                }

                PopulateTestData(dbContext);
            }
        }
        public static void PopulateTestData(AppDbContext dbContext)
        {
            foreach (var item in dbContext.Entries)
            {
                dbContext.Remove(item);
            }
            dbContext.SaveChanges();

            //TestPhoneBook.Entries.Add(entry1);
            //TestPhoneBook.Entries.Add(entry2);
            //TestPhoneBook.Entries.Add(entry3);
            //dbContext.PhoneBooks.Add(TestPhoneBook);

            //dbContext.SaveChanges();
        }
    }
}
