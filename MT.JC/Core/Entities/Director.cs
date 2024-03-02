using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Director : IEntity
    {
        #region Properties

        //TODO: add attributes like MaxLength ..

        [Key]
        public long Id { get; set; }

        public required string Firstname { get; set; }

        public required string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        public string? Nationality { get; set; }

        #endregion
    }
}