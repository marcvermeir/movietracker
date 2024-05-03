using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFxDisconnectedUpdates.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [ForeignKey("Author")]
        public int FKAuthor {  get; set; }

        public Author Author { get; set; }  
    }
}
