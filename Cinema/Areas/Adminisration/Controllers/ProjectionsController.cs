using Cinema.Core.Contracts;
using Cinema.Core.Models.Projection;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Areas.Adminisration.Controllers
{
    public class ProjectionsController : Controller
    {
        private readonly IProjectionService projectionService;

        public ProjectionsController(IProjectionService _projectionService)
        {
            projectionService = _projectionService;
        }

        public async Task<IActionResult> Details(int projectionId)
        {
            var model = await projectionService.GetProjectionDetails(projectionId);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AllProjection()
        {
            var model = await projectionService.GetAllProjectionAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddProjection()
        {
            var model = new AddProjectionViewModel()
            {
                Halls = await projectionService.GetHallAsync(),
                Movies = await projectionService.GetAllMoviesAsync()

            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProjection(AddProjectionViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Movies = await projectionService.GetAllMoviesAsync();
                model.Halls = await projectionService.GetHallAsync();
                return View(model);
            }

            try
            {
                await projectionService.AddProjectionAsync(model);

                return RedirectToAction("All", "Movies");
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Something went wrong");

                model.Movies = await projectionService.GetAllMoviesAsync();
                model.Halls = await projectionService.GetHallAsync();
                return View(model);

            }
        }
    }
}
