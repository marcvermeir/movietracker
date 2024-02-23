namespace MT.Api.Core.Domain
{
    using System.Collections.Generic;

    public interface IMovieService
    {
        Task<List<Movie>> GetMoviesAsync();

        Task<Movie> GetMovieAsync(int id);
    }
}