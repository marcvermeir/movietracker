////using MovieTracker.Core.Domain;
////using System.Data.Entity.ModelConfiguration;

////namespace MovieTracker.Infra.EntityConfigurations
////{
////    public class WatchlistConfiguration : EntityTypeConfiguration<Watchlist>
////    {
////        public WatchlistConfiguration() 
////        {
////            // public long Id { get; set; }
////            // public string Title { get; set; }

////            Property(x => x.Title)
////               .IsRequired()
////               .HasMaxLength(50);

////            HasMany<WatchlistItem>(x => x.WatchlistItems)
////                .WithRequired(y => y.)
////        }
////    }
////}