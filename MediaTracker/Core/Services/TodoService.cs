using Core.Entities;
using Core.UnitOfWork;

namespace Core.Services
{
    public class TodoService : ITodoService
    {
        private IUnitOfWork _unitOfWork;

        #region Ctor

        public TodoService(IUnitOfWork unitOfWork ) 
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork ));
        }

        #endregion

        #region Methods

        public async Task<IEnumerable<Todo>> GetTodos4UserAsync(int userId)
        {
            _ = userId > 0 ? true : throw new ArgumentOutOfRangeException(nameof(userId));

            var todos = await _unitOfWork.TodoRepository.GetManyAsync(filter: t => t.UserId == userId, orderBy: t => t.OrderBy(t => t.Id));

            return todos;
        }

        #endregion
    }
}