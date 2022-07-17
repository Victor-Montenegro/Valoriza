using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Valoriza.Domain.Entities;

namespace Valoriza.Infrastructure.EF.Mappers
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Admin)
                .HasColumnName("Admin");

            builder.Property(x => x.Name)
                .HasColumnName("Name");

            builder.Property(x => x.Password)
                .HasColumnName("Password");

            builder.Property(x => x.Email)
                .HasColumnName("Email");

            builder.Property(x => x.CreationDate)
                .HasColumnName("CreationDate");

            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate");

            builder.Property(x => x.DeletionDate)
                .HasColumnName("DeletionDate");
        }
    }
}