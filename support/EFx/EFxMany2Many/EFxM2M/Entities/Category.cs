using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFxM2M.Entities
{
    public class Category
    {
        public Category() 
        { 
            Books = new HashSet<Book>();
        }

        public int CategoryId { get; set; }

        [MaxLength(255)]
        public string CategoryName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
