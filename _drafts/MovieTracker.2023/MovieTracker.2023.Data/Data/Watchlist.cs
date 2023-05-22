using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTracker.Data.Data
{
    [Table("Watchlist")]
    public partial class Watchlist
    {
        [Key]
        [DatabaseGenerat‌​ed(DatabaseGeneratedOption.None)]
        public long WatchlistID { get; set; }

        [Required]
        //??? [Index(IsUnique = true)]
        [MaxLength(50)]
        public string? Title { get; set; }


        [Timestamp]
        public Byte[]? TimeStamp { get; set; }

        public virtual ICollection<WatchlistItem>? WatchlistItems { get; set; }

        //TODO: >>> public string BuildSearchTerms() => $"{CustomerID} {FirstName} {LastName} {EmailAddress} {AddressLine1}".ToLower();
    }
}