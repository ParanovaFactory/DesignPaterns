using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPatern.Observer.DAL
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=PREDATOR; initial catalog=DesignPattern3; integrated security=true");
        }

        public DbSet<UserProcess> userProcesses { get; set; }
        public DbSet<Discaunt> discaunts { get; set; }
        public DbSet<WelcomeMessage> welcomeMessages { get; set; }
    }
}
