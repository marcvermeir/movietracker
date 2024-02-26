using MT.Api.Data;
using MT.Api.Resources;
using MT.Api.Services.DataServiceFactory;

namespace MT.Api.Core.Domain
{
    public class MovieService : IMovieService
    {
        private IDataServiceFactory _dataServiceFactory { get; }

        public MovieService(IDataServiceFactory dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory ?? throw new ArgumentNullException(nameof(dataServiceFactory));
        }

        public Task<MovieResource> GetMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<MovieResource>> GetMoviesAsync(DataRequest<Movie> request)
        {
            throw new NotImplementedException();
        }
    }
}