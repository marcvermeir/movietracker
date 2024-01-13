using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.Username).IsRequired().HasMaxLength(50);
        }

        #endregion
    }
}
