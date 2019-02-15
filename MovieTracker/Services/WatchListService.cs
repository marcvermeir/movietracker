using MovieTracker.Core.Interfaces;
using MovieTracker.Interfaces;
using MovieTracker.ViewModels;
using System;
using System.Threading.Tasks;

namespace MovieTracker.Services
{
    public class WatchListService : IWatchListService
    {
        private readonly IMovieRepository _movieRepository;


        public WatchListService(IMovieRepository movieRepository)
        {
            //todo: guard(movieRepository)

            _movieRepository = movieRepository;
        }


        public Task<WatchListViewModel> GetWatchListMovies(int pageIndex, int itemsPage, int? userId)
        {
            //todo: _logger.LogInformation("...");

            //TODO: ...

            throw new NotImplementedException();
        }
    }
}
