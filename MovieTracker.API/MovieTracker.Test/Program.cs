using MovieTracker.Infra;
using System.Data.Entity;

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
                unitOfWork.Watchlists.Add(new Core.Domain.Watchlist() { Title = "WL1" });

                unitOfWork.Complete();
            }
        }
    }
}
