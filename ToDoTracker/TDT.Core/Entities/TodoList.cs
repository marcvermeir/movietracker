using TDT.Core.Interfaces;

namespace TDT.Core.Entities
{
    public class TodoList : IHasId
    {
        #region Properties

        public int Id => throw new NotImplementedException();

        /// <summary>
        /// The Title/Description of the Todo item.
        /// </summary>
        public string Title { get; set; }


        #endregion
    }
}