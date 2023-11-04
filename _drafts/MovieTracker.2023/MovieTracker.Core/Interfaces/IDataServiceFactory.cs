namespace MovieTracker.Core.Interfaces
{
    public interface IDataServiceFactory
    {
        IDataService CreateDataService();
    }
}