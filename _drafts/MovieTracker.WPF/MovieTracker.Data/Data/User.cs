using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Data.Data
{
    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerat‌​ed(DatabaseGeneratedOption.Identity)]
        public long UserID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }


    }
}
