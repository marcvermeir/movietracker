namespace MovieTracker.Core.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}