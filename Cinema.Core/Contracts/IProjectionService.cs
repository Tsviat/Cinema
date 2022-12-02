using Cinema.Core.Models.Projection;
using CInema.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Core.Contracts
{
    public interface IProjectionService
    {
        Task<IEnumerable<ProjectionViewModel>> GetAllProjectionAsync();

        Task<IEnumerable<Hall>> GetHallAsync();

        Task<IEnumerable<Movie>> GetAllMoviesAsync();

        Task AddProjectionAsync(AddProjectionViewModel model);

        Task<ProjectionViewModel> GetProjectionDetails(int projectionId);
    }
}
