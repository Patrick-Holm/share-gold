using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldDiggerWebApi.Models
{
    public class GoldDiggerDbContext : DbContext
    {
        public GoldDiggerDbContext(DbContextOptions<GoldDiggerDbContext> options) : base(options)
        {

            Database.EnsureCreated();

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PriciousMetals> PriciousMetals { get; set; }
        public DbSet<DollarRate> DollarRates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
        .ToTable("Customer");
       //     modelBuilder.Entity<PriciousMetals>()
       //.ToTable("PriciousMetals");
            modelBuilder.Entity<DollarRate>()
       .ToTable("DollarRate");



            //   seeding i databasen. husk foreign key id.
            #region GrainSeed 
            DateTime current = DateTime.MinValue;

            modelBuilder.Entity<DollarRate>().HasData(
                new DollarRate() { Id = 1, RateDate = current, RateOfExhange = 0 });
                

            modelBuilder.Entity<Customer>().HasData(
              new Customer() { Id = 1, Name = "Peder Sky", Address = "SkyBrud 25", ZipCode = "5522", Country = "Denmark", PhoneNumber = "72124136", MailAdress = "Cloud@high.com", MemberKey = "Key", MemberDate = DateTime.Now },
              new Customer() { Id = 2, Name = "Peder Sky", Address = "SkyBrud 25", ZipCode = "5522", Country = "Denmark", PhoneNumber = "72124136", MailAdress = "Cloud@high.com", MemberKey = "Key", MemberDate = DateTime.Now },
              new Customer() { Id = 3, Name = "Peder Sky", Address = "SkyBrud 25", ZipCode = "5522", Country = "Denmark", PhoneNumber = "72124136", MailAdress = "Cloud@high.com", MemberKey = "Key", MemberDate = DateTime.Now });


            modelBuilder.Entity<PriciousMetals>().HasData(
                new PriciousMetals() { Id = 1, Name = "Platinum", PriceInUSD = 125, PriceInDKK = 125 },
                new PriciousMetals() { Id = 2, Name = "Gold", PriceInUSD = 632, PriceInDKK = 125 },
                new PriciousMetals() { Id = 3, Name = "Rhodium", PriceInUSD = 863, PriceInDKK = 125 },
                new PriciousMetals() { Id = 4, Name = "Palladium", PriceInUSD = 231, PriceInDKK = 125 },
                new PriciousMetals() { Id = 5, Name = "Lead", PriceInUSD = 31, PriceInDKK = 125 },
                new PriciousMetals() { Id = 6, Name = "Silver", PriceInUSD = 242, PriceInDKK = 125 },
                new PriciousMetals() { Id = 7, Name = "Copper", PriceInUSD = 123, PriceInDKK = 125 },
                new PriciousMetals() { Id = 8, Name = "Nickel", PriceInUSD = 64, PriceInDKK = 125 },
                new PriciousMetals() { Id = 9, Name = "Iron", PriceInUSD = 532, PriceInDKK = 125 },
                new PriciousMetals() { Id = 10, Name = "Zinc", PriceInUSD = 234, PriceInDKK = 125 },
                new PriciousMetals() { Id = 11, Name = "Chromium", PriceInUSD = 136, PriceInDKK = 125 },
                new PriciousMetals() { Id = 12, Name = "Tin", PriceInUSD = 16, PriceInDKK = 125 },
                new PriciousMetals() { Id = 13, Name = "Titanium", PriceInUSD = 172, PriceInDKK = 125 },
                new PriciousMetals() { Id = 14, Name = "Aluminum", PriceInUSD = 241, PriceInDKK = 125 });
 

               







        }
    }
}
#endregion