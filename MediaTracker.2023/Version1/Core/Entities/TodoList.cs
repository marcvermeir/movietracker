namespace Core.Entities
{
    public class TodoList
    {
        #region Properties

        public int Id { get; set; }

        public required string Title { get; set; }

        //TODO: add image/icon property

        // One-to-many relationship with todos
        public List<Todo>? Todos { get; set; }

        #endregion
    }
}
