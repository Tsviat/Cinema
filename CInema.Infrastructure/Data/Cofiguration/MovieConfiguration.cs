using CInema.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CInema.Infrastructure.Data.Cofiguration
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(CreateMovies());
        }

        private List<Movie> CreateMovies()
        {
            var movies = new List<Movie>();

            var movie = new Movie()
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                ReleaseDate = 1994,
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Rating = 9.3m,
                ImageURL = "https://flxt.tmsimg.com/assets/p15987_p_v8_ai.jpg",
                GenreId = 3
            };

            movies.Add(movie);

            movie = new Movie()
            {
                Id = 2,
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                ReleaseDate = 1972,
                Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.",
                Rating = 9.2m,
                ImageURL = "https://i.ytimg.com/vi/U8GdYixWfOc/movieposter_en.jpg",
                GenreId = 6
            };

            movies.Add(movie);

            movie = new Movie()
            {
                Id = 3,
                Title = "Schindler's List",
                Director = "Steven Spielberg",
                ReleaseDate = 1993,
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                Rating = 9m,
                ImageURL = "https://www.uklfi.com/wp-content/uploads/2022/05/Schindlers-list.jpg",
                GenreId = 3
            };

            movies.Add(movie);

            return movies;
        }
}
}
