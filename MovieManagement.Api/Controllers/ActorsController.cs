using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Repositories.Interfaces;

namespace MovieManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var actorsFromRepo = _unitOfWork.Actor.GetAll().ToList();
            return Ok(actorsFromRepo);
        }

        [HttpGet("movies")]
        public ActionResult GetWithMovies()
        {
            var actorsWithMoviesFromRepo = _unitOfWork.Actor.GetActorsWithMovies();
            return Ok(actorsWithMoviesFromRepo);
        }


    }
}
