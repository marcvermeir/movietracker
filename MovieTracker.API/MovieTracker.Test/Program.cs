using MovieTracker.Core.Domain;
using MovieTracker.Infra;
using System.Data.Entity;
using System.Diagnostics;

namespace MovieTracker.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MovieTrackerContext>());
            Database.SetInitializer(new MovieTrackerDBInitializer());

            using (var context = new MovieTrackerContext())
            {
                context.Database.Initialize(force: true);
                context.Database.CreateIfNotExists();
            }


            using (var unitOfWork = new UnitOfWork(new MovieTrackerContext()))
            {
                ///

                Watchlist watchlist = new Watchlist();
                watchlist.Title = "WL2";

                WatchlistItem watchlistItem = new WatchlistItem();
                watchlistItem.Title = "Movie2";

                watchlist.WatchlistItems.Add(watchlistItem);

                unitOfWork.Watchlists.Add(watchlist);

                unitOfWork.Complete();

                ///

                var wl = unitOfWork.Watchlists.GetWatchlistWithWatchlistItems(2);
                Debug.Assert(wl != null);

                /// ?! the following should not be possible .. ?!

                watchlistItem = new WatchlistItem();
                watchlistItem.Title = "Movie?";

                unitOfWork.WatchlistItems.Add(watchlistItem);

                unitOfWork.Complete();

            }
        }
    }
}
