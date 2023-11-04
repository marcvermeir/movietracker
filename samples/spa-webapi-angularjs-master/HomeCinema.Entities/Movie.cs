using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities
{
    public class Movie : IEntityBase
    {
        public Movie()
        {
            Stocks = new List<Stock>();
        }
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        // >>>
        [Required]
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }
        // <<<
        
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte Rating { get; set; }
        public string TrailerURI { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
