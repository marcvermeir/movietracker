using System.Data.Entity;

namespace EFxM2M.Entities
{
    public class EntitiesCtx : DbContext
    {
        // Your context has been configured to use a 'Entities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EFxM2M.Entities.Entities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Entities' 
        // connection string in the application configuration file.
        public EntitiesCtx()
            : base("name=Entities")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = true;
            this.Configuration.AutoDetectChangesEnabled = false;

            // Database.SetInitializer(new DropCreateDatabaseAlways<EntitiesCtx>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}