using Microsoft.EntityFrameworkCore;

namespace EpargneRichard.Models
{
    public class AppDbContext:DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<SavingAccount> SavingAccounts { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            // I add a connection to a database instance while the context configures

            optionsBuilder.UseSqlServer(

                @"Server=LOCALHOST;Database=SavingAccount;TrustServerCertificate=true;Integrated Security=sspi");

        }

    }
}
