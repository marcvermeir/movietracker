namespace Core.Entities
{
    /// <summary>
    /// Represents a User.
    /// </summary>
    public class User : IEntity
    {
        #region Properties

        /// <summary>
        /// The unique ID of the User.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Username of the User.
        /// </summary>
        public required string Username { get; set; }

        #endregion
    }
}