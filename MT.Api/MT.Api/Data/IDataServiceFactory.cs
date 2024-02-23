namespace MT.Api.Data
{
    public interface IDataServiceFactory
    {
        IDataService CreateDataService();
    }
}