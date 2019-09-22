using apiLeviathansChilds.domain.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apiLeviathansChilds.infra.map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> userConfiguration)
        {
            userConfiguration.ToTable("user");
            userConfiguration.OwnsOne(user => user.email, email =>
            {
                email.Property(email => email.adress).HasColumnType("varchar(50)").IsRequired().HasColumnName("email");
                email.HasIndex(email => email.adress).HasName("UK_USER_EMAIL").IsUnique();
            });

            userConfiguration.OwnsOne(user => user.name, name =>
            {
                name.Property(name => name.firstName).HasColumnType("varchar(50)").IsRequired().HasColumnName("firstName");
                name.Property(name => name.lastName).HasColumnType("varchar(50)").IsRequired().HasColumnName("lastName");
            });

            userConfiguration.HasIndex(user => user.nick).HasName("UK_USER_NICK").IsUnique();
            userConfiguration.Property(user => user.nick).HasColumnType("varchar(50)").IsRequired().HasColumnName("nick");

            userConfiguration.Property(user => user.password).HasColumnType("varchar(50)").IsRequired().HasColumnName("password");

            userConfiguration.Property(user => user.status).IsRequired().HasColumnName("status");
        }
    }
}