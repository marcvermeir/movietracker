namespace TDT.Core.Interfaces
{
    /// <summary>
    /// Interface for all entities which have an ID primary key.
    /// </summary>
    public interface IHasId
    {
        #region Properties

        int Id { get; }

        #endregion
    }
}