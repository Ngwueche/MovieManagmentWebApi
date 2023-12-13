using Microsoft.AspNetCore.Mvc;
using MovieManagement.Domain.Entities;
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
            var actorsFromRepo = _unitOfWork.Actor.GetAll();
            return Ok(actorsFromRepo);
        }

        [HttpGet("movies")]
        public ActionResult GetWithMovies()
        {
            var actorsWithMoviesFromRepo = _unitOfWork.Actor.GetActorsWithMovies();
            return Ok(actorsWithMoviesFromRepo);
        }
        [HttpPost("add-actor")]
        public ActionResult Add(Actor actor)
        {
            var result = _unitOfWork.Actor.Add(actor);
            if (result is not null)
            {
                return Ok();
            }
            return BadRequest(result);
        }


    }
}
