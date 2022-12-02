using Cinema.Core.Contracts;
using Cinema.Core.Models.Projection;
using Cinema.Infrastructure.Data.Common;
using CInema.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Core.Services
{
    public class ProjectionService : IProjectionService
    {
        private readonly IRepository repo;


        public ProjectionService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task AddProjectionAsync(AddProjectionViewModel model)
        {
            var entity = new Projection()
            {
                MovieId = model.MovieId,
                HallId = model.HallId,
                StartMovie = model.StartMovie,
            };

            await repo.AddAsync<Projection>(entity);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await repo.AllReadonly<Movie>()
                .ToListAsync();
        }

        public async Task<IEnumerable<ProjectionViewModel>> GetAllProjectionAsync()
        {
            var model = await repo.AllReadonly<Projection>()
                .Select(p => new ProjectionViewModel()
                {
                    Id = p.Id,
                    Movie = p.Movie,
                    Hall = p.Hall.Name,
                    StartMovie = p.StartMovie

                })
                .ToListAsync();

            return model;
        }

        public async Task<IEnumerable<Hall>> GetHallAsync()
        {
            return await repo.AllReadonly<Hall>()
                .ToListAsync();
        }

        public async Task<ProjectionViewModel> GetProjectionDetails(int projectionId)
        {
            var model = await repo.AllReadonly<Projection>()
                .Where(p => p.Id == projectionId)
                .Select(p => new ProjectionViewModel()
                {
                    Id = p.Id,
                    Movie = p.Movie,
                    Hall = p.Hall.Name, 
                    StartMovie = p.StartMovie
                    
                })
                .FirstAsync();

            return model;
        }
    }
}
