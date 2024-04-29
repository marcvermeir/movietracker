using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDT.Core.Entities;

namespace TDT.Data.Configurations
{
    /// <summary>
    /// Configures Todo specific mappings.
    /// </summary>
    internal class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        #region Methods

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder used to configure the entity</param>
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(100);
        }

        #endregion
    }
}