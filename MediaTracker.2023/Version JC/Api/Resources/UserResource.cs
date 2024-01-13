namespace Api.Resources
{
    public class UserResource
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