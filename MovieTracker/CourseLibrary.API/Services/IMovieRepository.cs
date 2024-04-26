using MovieTracker.API.Entities;

namespace MovieTracker.API.Services
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetMoviesAsync(Guid watchlistId);
        Task<Movie> GetMovieAsync(Guid watchlistId, Guid movieId);
        void AddMovie(Guid watchlistId, Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(Movie movie);
        
        Task<IEnumerable<Watchlist>> GetWatchlistsAsync();
        Task<Watchlist> GetWatchlistAsync(Guid watchlistId);
        Task<IEnumerable<Watchlist>> GetWatchlistsAsync(IEnumerable<Guid> watchlistIds);
        void AddWatchlist(Watchlist watchlist);
        void DeleteWatchlist(Watchlist watchlist);
        void UpdateWatchlist(Watchlist watchlist);
        
        Task<bool> WatchlistExistsAsync(Guid watchlistId);
        Task<bool> SaveAsync();
    }
}