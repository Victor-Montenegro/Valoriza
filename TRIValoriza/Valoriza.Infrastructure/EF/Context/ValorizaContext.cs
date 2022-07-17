using Microsoft.EntityFrameworkCore;
using Valoriza.Core.Services.Security;
using Valoriza.Domain.Entities;

namespace Valoriza.Infrastructure.EF.Context
{
    public class ValorizaContext : DbContext
    {
        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Compliments> Compliments { get; set; }

        public ValorizaContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ValorizaContext).Assembly);

            User user = new User("Admin","admin@admin.com.br",true);
            user.Id = 1;

            user.EncryptPassword("123456", new CryptographySHA512Service());

            modelBuilder.Entity<User>().HasData(user);

            modelBuilder.Entity<User>().HasQueryFilter(x => x.DeletionDate != null);
        }
    }
}