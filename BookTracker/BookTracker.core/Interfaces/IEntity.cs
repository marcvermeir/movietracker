namespace BookTracker.core.Interfaces
{
    /// <summary>
    /// Interface for all entities which have an ID primary key.
    /// </summary>
    public interface IEntity
    {
        #region Properties

        long Id { get; }

        #endregion
    }
}
