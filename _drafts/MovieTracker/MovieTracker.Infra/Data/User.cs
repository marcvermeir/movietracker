using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTracker.Infra.Data
{
    [Table("Users")]
    public partial class User
    {
        [Key]
        [DatabaseGenerat‌​ed(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailAddress { get; set; }

        public virtual ICollection<MItem> WatchList { get; set; }

        public string BuildSearchTerms() => $"{ID} {FirstName} {LastName} {EmailAddress}".ToLower();
    }
}
