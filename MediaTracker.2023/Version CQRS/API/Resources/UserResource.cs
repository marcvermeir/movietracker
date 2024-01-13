namespace API.Resources
{
    public class UserResource
    {
        public int Id { get; init; }
        public required string FirstName { get; init; }
        public required string LastName { get; init; }

        //// public IList<Address>? Addresses { get; init; }

        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}