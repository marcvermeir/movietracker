namespace MT.Api.Data
{
    public class SQLServerDataService : DataServiceBase
    {
        public SQLServerDataService(string connectionString)
            : base(new SQLServerDb(connectionString))
        {
        }
    }
}