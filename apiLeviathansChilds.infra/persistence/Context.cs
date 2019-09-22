using Microsoft.Extensions.Configuration;
using apiLeviathansChilds.domain.entities;
using Microsoft.EntityFrameworkCore;
using apiLeviathansChilds.infra.map;
using prmToolkit.NotificationPattern;

namespace apiLeviathansChilds.infra.persistence
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseNpgsql("Server=ec2-107-21-120-104.compute-1.amazonaws.com;Port=5432;Database=d1qpflu2ge096f;User Id=hlijyndmgrwthy; Password=6b908ab41772f28cd4b524e49393930babfa93cd7965572dec93d8accb87e835;SSL Mode=Require;Trust Server Certificate=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.Ignore<Notification>();
            base.OnModelCreating(modelBuilder);
        }
    }
}