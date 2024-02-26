using MT.Api.Core.Domain;

namespace MT.Api.Data.DataServices
{
    public interface IDataService : IDisposable
    {
        Task<Movie> GetMovieAsync(int id);
        Task<IList<Movie>> GetMoviesAsync(int skip, int take, DataRequest<Movie> request);
        Task<IList<Movie>> GetMovieKeysAsync(int skip, int take, DataRequest<Movie> request);
        Task<int> GetMoviesCountAsync(DataRequest<Movie> request);
        Task<int> UpdateMovieAsync(Movie customer);
        Task<int> DeleteMoviesAsync(params Movie[] customers);
    }
}