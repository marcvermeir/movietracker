using MT.Api.Data;

namespace MT.Api.Core.Domain
{
    public class MovieService : IMovieService
    {
        /*
        private readonly List<Movie> _movies;
        */

        private readonly IDataServiceFactory _dataServiceFactory { get; }

        public MovieService(IDataServiceFactory dataServiceFactory)
        {
            _dataServiceFactory = dataServiceFactory ?? throw new ArgumentNullException(nameof(dataServiceFactory));

            /* 
            _movies = new List<Movie>
            {
                new()
                {
                    Id = 1,
                    Title = "Blade Runner 2049",
                    Director = "Scott, Ridley",
                    IMDBRef = "https://www.imdb.com/title/tt1856101/?ref_=ext_shr_lnk"
                },
                new()
                {
                    Id = 2,
                    Title = "Child 44",
                    Director = "Espinosa,Daniel",
                    IMDBRef = "https://www.imdb.com/title/tt1014763/?ref_=fn_al_tt_1"
                },
                new()
                {
                    Id = 3,
                    Title = "Das Boot",
                    Director = "Petersen, Wolfgang",
                    IMDBRef = "https://www.imdb.com/title/tt0082096/?ref_=fn_al_tt_2"
                }
            };
            */
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            return this._movies;
        }

        public Task<Movie> GetMovieAsync(int id)
        {
            var movie = this._movies.FirstOrDefault(x => x.Id == id);

            return movie;
        }
    }
}