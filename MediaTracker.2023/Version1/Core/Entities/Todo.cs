namespace Core.Entities
{
    /// <summary>
    /// Represents a 'Todo' item.
    /// </summary>
    public class Todo : IEntity
    {
        #region Properties

        /// <summary>
        /// The unique ID of the Todo item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Title/Description of the Todo item.
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// Whether or not the Todo item has been completed.
        /// </summary>
        public bool Completed { get; set; }

        // One-to-many relation with the 'Creator'
        public int CreatorId { get; set; }
        public required User Creator { get; set; }

        // One-to-many relation with a 'TodoList'
        public int? TodoListId { get; set; }
        public TodoList? TodoList { get; set; }

        #endregion
    }
}