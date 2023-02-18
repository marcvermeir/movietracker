using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public CategoryType Category { get; set; }    // = M 4 movie, S 4 tvshow

        [MaxLength(5)]
        public string Status { get; set; }

        [MaxLength(250)]
        public string Description { get; set; }
    }
}
