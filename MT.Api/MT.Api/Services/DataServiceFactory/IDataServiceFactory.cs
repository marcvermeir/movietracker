using MT.Api.Data.DataServices;

namespace MT.Api.Services.DataServiceFactory
{
    public interface IDataServiceFactory
    {
        IDataService CreateDataService();
    }
}