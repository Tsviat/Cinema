using Cinema.Core.Contracts;
using Cinema.Core.Models.Movies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Areas.Administration.Controllers
{
    //[Area("Administration")]
    //[Route("[area]/[controller]")]
    [Authorize]
    public class MoviesController : Controller
    {
        private readonly IMovieService movieService;

        public MoviesController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        //[HttpGet]
        //public async Task<IActionResult> All()
        //{
        //    var model = await movieService.GetAllAsync();

        //    return View(model);
        //}

        

        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            var model = new AddMovieViewModel()
            {
                Genres = await movieService.GetGenresAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = await movieService.GetGenresAsync();
                return View(model);
            }

            try
            {
                await movieService.AddMovieAsync(model);

                return RedirectToAction("All", "Movies");
            }
            catch (Exception)
            {

                ModelState.AddModelError("", "Something went wrong");

                model.Genres = await movieService.GetGenresAsync();

                return View(model);
            }
        }

        //public async Task<IActionResult> AddToCollection(int movieId) 
        //{
        //    try
        //    {
        //        var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

        //        await movieService.AddMovieToCollectionAsync(movieId, userId);
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    return RedirectToAction(nameof(All));
        //}

        //public async Task<IActionResult> Watched() 
        //{
        //    var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

        //    var model = await movieService.GetWhatchedAsync(userId);

        //    return View("Mine", model);
        //}

        //public async Task<IActionResult> RemoveFromCollection(int movieId) 
        //{
        //    var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

        //    await movieService.RemoveMovieFromCollectionAsync(movieId, userId);

        //    return RedirectToAction(nameof(Watched));

        //}
    }
}
