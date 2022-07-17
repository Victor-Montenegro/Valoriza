using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Valoriza.Domain.Entities;

namespace Valoriza.Infrastructure.EF.Mappers
{
    public class TagMapping : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.Name)
                .HasColumnName("Name");

            builder.Property(x => x.CreationDate)
                .HasColumnName("CreationDate");

            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate");

            builder.Property(x => x.DeletionDate)
                .HasColumnName("DeletionDate");
        }
    }
}