using MovieTracker.API.DbContexts;
using MovieTracker.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace MovieTracker.API.Services;

public class MovieRepository : IMovieRepository
{
    private readonly MovieTrackerContext _context;

    public MovieRepository(MovieTrackerContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void AddMovie(Guid watchlistId, Movie movie)
    {
        if (watchlistId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(watchlistId));
        }

        if (movie == null)
        {
            throw new ArgumentNullException(nameof(movie));
        }

        // always set the WatchlistId to the passed-in watchlistId
        movie.WatchlistId = watchlistId;
        _context.Movies.Add(movie);
    }

    public void DeleteMovie(Movie movie)
    {
        _context.Movies.Remove(movie);
    }

    public async Task<Movie> GetMovieAsync(Guid watchlistId, Guid movieId)
    {
        if (watchlistId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(watchlistId));
        }

        if (movieId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(movieId));
        }

#pragma warning disable CS8603 // Possible null reference return.
        return await _context.Movies
          .Where(m => m.WatchlistId == watchlistId && m.Id == movieId).FirstOrDefaultAsync();
#pragma warning restore CS8603 // Possible null reference return.
    }

    public async Task<IEnumerable<Movie>> GetMoviesAsync(Guid watchlistId)
    {
        if (watchlistId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(watchlistId));
        }

        return await _context.Movies
                    .Where(m => m.WatchlistId == watchlistId)
                    .OrderBy(c => c.Title).ToListAsync();
    }

    public void UpdateMovie(Movie movie)
    {
        // no code in this implementation
    }

    public void AddWatchlist(Watchlist watchlist)
    {
        if (watchlist == null)
        {
            throw new ArgumentNullException(nameof(watchlist));
        }

        // the repository fills the id (instead of using identity columns)
        watchlist.Id = Guid.NewGuid();

        foreach (var movie in watchlist.Movies)
        {
            movie.Id = Guid.NewGuid();
        }

        _context.Watchlists.Add(watchlist);
    }

    public async Task<bool> WatchlistExistsAsync(Guid watchlistId)
    {
        if (watchlistId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(watchlistId));
        }

        return await _context.Watchlists.AnyAsync(w => w.Id == watchlistId);
    }

    public void DeleteWatchlist(Watchlist watchlist)
    {
        if (watchlist == null)
        {
            throw new ArgumentNullException(nameof(watchlist));
        }

        _context.Watchlists.Remove(watchlist);
    }

    public async Task<Watchlist> GetWatchlistAsync(Guid watchlistId)
    {
        if (watchlistId == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(watchlistId));
        }

#pragma warning disable CS8603 // Possible null reference return.
        return await _context.Watchlists.FirstOrDefaultAsync(w => w.Id == watchlistId);
#pragma warning restore CS8603 // Possible null reference return.
    }


    public async Task<IEnumerable<Watchlist>> GetWatchlistsAsync()
    {
        return await _context.Watchlists.ToListAsync();
    }

    public async Task<IEnumerable<Watchlist>> GetWatchlistsAsync(IEnumerable<Guid> watchlistIds)
    {
        if (watchlistIds == null)
        {
            throw new ArgumentNullException(nameof(watchlistIds));
        }

        return await _context.Watchlists.Where(w => watchlistIds.Contains(w.Id))
            .OrderBy(w => w.Title)
            .ToListAsync();
    }

    public void UpdateWatchlist(Watchlist watchlist)
    {
        // no code in this implementation
    }

    public async Task<bool> SaveAsync()
    {
        return (await _context.SaveChangesAsync() >= 0);
    }
}