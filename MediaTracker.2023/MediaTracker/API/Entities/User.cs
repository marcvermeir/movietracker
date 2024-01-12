namespace API.Entities
{
    public record User : IEntity
    {
        public required string FirstName { get; init; }

        public required string LastName { get; init; }

        //// public virtual ICollection<Address> Addresses { get; init; }
    }
}