using Cinema.Core.Contracts;
using Cinema.Core.Models.Movies;
using Cinema.Infrastructure.Data;
using Cinema.Infrastructure.Data.Common;
using CInema.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository repo;


        public MovieService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddMovieAsync(AddMovieViewModel model)
        {
            var entity = new Movie()
            {
                Director = model.Director,
                Title = model.Title,
                Description = model.Description,
                ReleaseDate = model.ReleaseDate,
                GenreId = model.GenreId,
                ImageURL = model.ImageUrl,
                Rating = model.Rating
            };

            await repo.AddAsync<Movie>(entity);
            await repo.SaveChangesAsync();
        }

        //public async Task AddMovieToCollectionAsync(int movieId, string userId)
        //{
        //    var user = await context.Users
        //        .Where(u => u.Id == userId)
        //        .Include(u => u.UsersMovies)
        //        .FirstOrDefaultAsync();

        //    if (user == null) 
        //    {
        //        throw new ArgumentException("Invalid user ID");
        //    }
        //    var movie = await context.Movies.FirstOrDefaultAsync(m => m.Id == movieId);

        //    if (movie == null) 
        //    {
        //        throw new ArgumentException("Invalid movie ID");
        //    }

        //    if (!user.UsersMovies.Any(m => m.MovieId == movieId))
        //    {
        //        user.UsersMovies.Add(new UserMovie
        //        {
        //            UserId = userId,
        //            MovieId = movieId,
        //            Movie = movie,
        //            User = user

        //        });

        //        await context.SaveChangesAsync();
        //    }


        //}

        public async Task<IEnumerable<MovieViewModel>> GetAllAsync()
        {
            //var entities =  await context.Movies
            //    .Include(x => x.Genre)
            //    .ToListAsync();

            //return entities
            //    .Select(x => new MovieViewModel()
            //    {
            //        Id = x.Id,
            //        Title = x.Title,
            //        Genre = x.Genre.Name,
            //        Director = x.Director,
            //        ImageURL = x.ImageURL,
            //        Rating = x.Rating,
            //        ReleaseDate = x.ReleaseDate,
            //        Description = x.Description

            //    });

            var model = await repo.AllReadonly<Movie>()
                .Select(m => new MovieViewModel()
                {
                    Id = m.Id,
                    Title = m.Title,
                    Director = m.Director,
                    Description = m.Description,
                    ReleaseDate = m.ReleaseDate,
                    Rating = m.Rating,
                    ImageURL = m.ImageURL,
                    Genre = m.Genre.Name

                })
                .ToListAsync();

            return model;
        }

        //public async Task<IEnumerable<Genre>> GetGenresAsync()
        //{
        //    return await repo.All<Genres>.ToListAsync();
        //}
        public async Task<IEnumerable<Genre>> GetGenresAsync()
        {
            return await repo.AllReadonly<Genre>()
                .ToListAsync();
        }

        public async Task<MovieViewModel> GetMovieDetails(int movieId)
        {
            var model = await repo.AllReadonly<Movie>()
                .Where(m => m.Id == movieId)
                .Select(m => new MovieViewModel()
                {
                    Id = m.Id,
                    Title = m.Title,
                    Director = m.Director,
                    Description = m.Description,
                    ReleaseDate = m.ReleaseDate,
                    Rating = m.Rating,
                    ImageURL = m.ImageURL,
                    Genre = m.Genre.Name

                })
                .FirstAsync();

            return model;

        }



        //public async Task<IEnumerable<MovieViewModel>> GetWhatchedAsync(string userId)
        //{
        //    var user = await context.Users
        //        .Where(u => u.Id == userId)
        //        .Include(u => u.UsersMovies)
        //        .ThenInclude(u => u.Movie)
        //        .ThenInclude(u => u.Genre)
        //        .FirstOrDefaultAsync();

        //    if (user == null)
        //    {
        //        throw new ArgumentException("Invalid user ID");
        //    }

        //    return user.UsersMovies
        //        .Select(m => new MovieViewModel()
        //        { 
        //            Director = m.Movie.Director,
        //            Genre = m.Movie.Genre?.Name,
        //            Id = m.Movie.Id,
        //            ImageUrl = m.Movie.ImageUrl,
        //            Rating= m.Movie.Rating,
        //            Title = m.Movie.Title

        //        });
        //}

        //public async Task RemoveMovieFromCollectionAsync(int movieId, string userId)
        //{
        //    var user = await context.Users
        //        .Where(u => u.Id == userId)
        //        .Include(u => u.UsersMovies)              
        //        .FirstOrDefaultAsync();

        //    if (user == null)
        //    {
        //        throw new ArgumentException("Invalid user ID");
        //    }
        //    var movie = user.UsersMovies.FirstOrDefault(m => m.MovieId == movieId);

        //    if (movie != null)
        //    {
        //        user.UsersMovies.Remove(movie);
        //    }

        //    await context.SaveChangesAsync();
        //}
    }
}
