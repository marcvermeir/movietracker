using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MovieTracker.Infra.Data
{
    public enum CategoryType
    {
        Movie,
        TVShow
    }

    [Table("MItems")]
    public partial class MItem
    {
        [Key]
        [DatabaseGenerat‌​ed(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public CategoryType Category { get; set; }    // = M 4 movie, S 4 tvshow

        [MaxLength(5)]
        public string Status { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }

        public string BuildSearchTerms() => $"{ID} {Name} {Category} {Status} {Description}".ToLower();
    }
}
