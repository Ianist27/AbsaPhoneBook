using AbsaPhoneBook.Core.ProjectAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbsaPhoneBook.Infrastructure.Data.Config
{
    public class EntryConfiguration : IEntityTypeConfiguration<Entry>
    {
        public void Configure(EntityTypeBuilder<Entry> builder)
        {
            builder.Property(t => t.Name)
                .IsRequired();

            builder.Property(t => t.PhoneNumber)
               .IsRequired();
        }
    }
}
