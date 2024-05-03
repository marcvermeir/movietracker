using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFxDisconnectedUpdates.Entities
{
    public class Author
    {
        public Author() 
        {
            Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}