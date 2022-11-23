using Cinema.Core.Models.Movies;
using CInema.Infrastructure.Models;

namespace Cinema.Core.Contracts
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieViewModel>> GetAllAsync();

        Task<IEnumerable<Genre>> GetGenresAsync();

        Task<MovieViewModel> GetMovieDetails(int movieId);

        //Task AddMovieAsync(AddMovieViewModel model);

        //Task AddMovieToCollectionAsync(int movieId, string userId);

        //Task<IEnumerable<MovieViewModel>> GetWhatchedAsync(string userId);

        //Task RemoveMovieFromCollectionAsync(int movieId, string userId);
    }
}
