//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace BookTracker.API.Entities
//{
//    public class Book
//    {
//        [Key]
//        public Guid Id { get; set; }

//        [Required]
//        [MaxLength(50)]
//        public string Title { get; set; }

//        [ForeignKey("AuthorId")]
//        public Author Author { get; set; } = null!;

//        public Guid AuthorId { get; set; }

//        public Book(string title)
//        {
//            Title = title;
//        }
//    }
//}