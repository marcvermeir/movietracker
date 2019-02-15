using MovieTracker.ViewModels;
using System.Threading.Tasks;

namespace MovieTracker.Interfaces
{
    public interface IWatchListService
    {
        Task<WatchListViewModel> GetWatchListMovies(int pageIndex, int itemsPage, int? userId);
    }
}
