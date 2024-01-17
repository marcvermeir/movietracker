using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    internal class MediaItemConfiguration : IEntityTypeConfiguration<MediaItem>
    {
        #region Methods

        ////public void Configure(EntityTypeBuilder<User> builder)
        ////{
        ////    builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
        ////}

        public void Configure(EntityTypeBuilder<MediaItem> builder)
        {
            builder.Property(mi => mi.DirectorOrAuthor).IsRequired().HasMaxLength(50);
            builder.Property(mi => mi.Title).IsRequired().HasMaxLength(50);
        }

        #endregion
    }
}
