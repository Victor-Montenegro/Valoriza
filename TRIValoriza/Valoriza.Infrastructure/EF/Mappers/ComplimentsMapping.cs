using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Valoriza.Domain.Entities;

namespace Valoriza.Infrastructure.EF.Mappers
{
    public class ComplimentsMapping : IEntityTypeConfiguration<Compliments>
    {
        public void Configure(EntityTypeBuilder<Compliments> builder)
        {
            builder.ToTable("Compliments");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id");

            builder.Property(x => x.TagId)
                .HasColumnName("TagId");
            
            builder.Property(x => x.Message)
                .HasColumnName("Message");

            builder.Property(x => x.UserReceiver)
                .HasColumnName("UserReceiver");

            builder.Property(x => x.UserSender)
                .HasColumnName("UserSender");

            builder.Property(x => x.CreationDate)
                .HasColumnName("CreationDate");

            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate");

            builder.Property(x => x.DeletionDate)
                .HasColumnName("DeletionDate");

            builder.HasOne<Tag>()
                .WithMany()
                .HasForeignKey(x => x.Id);
        }
    }
}