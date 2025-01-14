using EFxM2M.Entities;
using System;
using System.Diagnostics;
using System.Linq;

namespace EFxM2M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new EntitiesCtx())
            {
                var thriller = db.Categories.Add(new Category() { CategoryName = "Thriller" });
                var adults = db.Categories.Add(new Category() { CategoryName = "Adults" });
                db.SaveChanges();

                ///

                Console.Write("Enter a title for a new Book: ");
                var title = Console.ReadLine();

                var book = new Book { Title = title };

                book.Categories.Add(thriller);
                book.Categories.Add(adults);

                var newBook = db.Books.Add(book);
                db.SaveChanges();

                ///

                var recentAddedBook = db.Books.AsNoTracking().Include("Categories").Where(b => b.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase)).First();

                Debug.Assert(recentAddedBook != null && recentAddedBook.BookId == newBook.BookId);

                ///

                Book bookWithOnlyOneCategory;

                var thrillerCategory = newBook.Categories.Where(c => c.CategoryName.Equals("Thriller", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                if (thrillerCategory != null)
                {
                    newBook.Categories.Remove(thrillerCategory);
                    db.SaveChanges();

                    bookWithOnlyOneCategory = db.Books.Find(newBook.BookId);

                    Debug.Assert(bookWithOnlyOneCategory.Categories.Count == 1);
                    Debug.Assert(bookWithOnlyOneCategory.Categories.First().CategoryName.Equals("Adults", StringComparison.InvariantCultureIgnoreCase));
                }

                ///

                var catThriller = db.Categories.AsNoTracking().Where(c => c.CategoryName.Equals("Thriller", StringComparison.InvariantCultureIgnoreCase)).First();
                bookWithOnlyOneCategory = db.Books.Find(newBook.BookId);

                Debug.Assert(bookWithOnlyOneCategory.BookId == newBook.BookId);

                bookWithOnlyOneCategory.Categories.Add(catThriller);
                db.SaveChanges();

                var bookWith2Categories = db.Books.AsNoTracking().Include("Categories").Where(b => b.BookId == newBook.BookId).First();

                Debug.Assert(bookWith2Categories.Categories.Count == 2);
            }
        }
    }
}
