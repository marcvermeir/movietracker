using System.Data.Entity.Migrations;

namespace MovieTracker.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MovieTrackerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}