using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFxM2M.Entities
{
    public class Book
    {
        public Book()
        {
            Categories = new HashSet<Category>();
        }

        public int BookId { get; set; }

        [MaxLength(255)]
        public string Title { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
