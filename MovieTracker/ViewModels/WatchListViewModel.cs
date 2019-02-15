using System.Collections.Generic;

namespace MovieTracker.ViewModels
{
    public class WatchListViewModel
    {
        public IEnumerable<MovieViewModel> WatchListMovies { get; set; }
    }
}
