using Microsoft.EntityFrameworkCore;

namespace DesignPatern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=PREDATOR; initial catalog=DesignPattern2; integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
