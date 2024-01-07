using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Configurations
{
    internal class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.Property(t => t.Title).IsRequired().HasMaxLength(100);
        }

        #endregion
    }
}
