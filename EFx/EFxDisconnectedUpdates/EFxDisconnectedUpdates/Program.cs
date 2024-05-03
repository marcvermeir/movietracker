using EFxDisconnectedUpdates.Entities;
using System.Data.Entity;
using System.Linq;

namespace EFxDisconnectedUpdates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisconnectedEFx.UpdateEntities();
        }
    }


    public static class DisconnectedEFx
    {
        public static void UpdateEntities()
        {
            Author author;
            // Read
            using (var ctx = new BooksDBContext())
            {
                author = ctx.Authors
                    .AsNoTracking()
                    .Include(x => x.Books)
                    .Where(x => x.Id == 4).FirstOrDefault();

                var dummy = author;
            }

            author.Books.ForEach(b =>
            {
                b.Description = "SK";
            });

            // Update
            using (var ctx = new BooksDBContext())
            {
                ctx.Authors.Add(author);
                if (author.Id > 0)
                    ctx.Entry(author).State = EntityState.Modified;

                author.Books.ForEach(b =>
                {
                    if (b.Id > 0)
                        ctx.Entry(b).State = EntityState.Modified;
                });

                ctx.SaveChanges();
            }
        }
    }
}
