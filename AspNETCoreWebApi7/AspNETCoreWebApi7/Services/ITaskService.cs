namespace AspNETCoreWebApi7.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<Models.Task>> ListAsync();
    }
}