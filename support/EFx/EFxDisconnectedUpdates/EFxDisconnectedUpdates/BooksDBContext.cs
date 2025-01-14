using EFxDisconnectedUpdates.Entities;
using System;
using System.Data.Entity;
using System.Diagnostics;

namespace EFxDisconnectedUpdates
{
    public class BooksDBContext : DbContext
    {
        // Your context has been configured to use a 'BooksDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EFxDisconnectedUpdates.BooksDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BooksDBContext' 
        // connection string in the application configuration file.
        public BooksDBContext()
            : base("name=BooksDBContext")
        {
            //disable initializer
            Database.SetInitializer<BooksDBContext>(null);

#if DEBUG
            this.Database.Log = Console.WriteLine;
#endif
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}