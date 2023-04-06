namespace MovieTracker.Core.Repositories
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}