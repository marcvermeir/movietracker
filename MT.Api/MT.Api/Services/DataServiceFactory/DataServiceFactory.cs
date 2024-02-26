using MT.Api.Data.DataServices;

namespace MT.Api.Services.DataServiceFactory
{
    public class DataServiceFactory : IDataServiceFactory
    {
        static private Random _random = new Random(0);

        public IDataService CreateDataService()
        {
            /* ????
            if (AppSettings.Current.IsRandomErrorsEnabled)
            {
                if (_random.Next(20) == 0)
                {
                    throw new InvalidOperationException("Random error simulation");
                }
            }
            */

            /* ????
            switch (AppSettings.Current.DataProvider)
            {
                case DataProviderType.SQLite:
                    return new SQLiteDataService(AppSettings.Current.SQLiteConnectionString);

                case DataProviderType.SQLServer:
                    return new SQLServerDataService(AppSettings.Current.SQLServerConnectionString);

                default:
                    throw new NotImplementedException();
            }
            */

            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MovieTracker; Trusted_Connection=True;";    //TODO:/ Configuration.GetConnectionString("DefaultConnection"); 

            return new SQLServerDataService(connectionString);

        }
    }
}