namespace MT.Api.Core.Domain
{
    using MT.Api.Data;
    using MT.Api.Resources;
    using System.Collections.Generic;

    public interface IMovieService
    {
        public Task<IList<MovieResource>> GetMoviesAsync(DataRequest<Movie> request);

        public Task<MovieResource> GetMovieAsync(int id);
    }
}