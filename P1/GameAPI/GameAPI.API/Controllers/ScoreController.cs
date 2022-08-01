using GameAPI.Data;
using GameAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        // Fields
        private readonly IRepository _repo;
        private readonly ILogger<ScoreController> _logger;

        // Constructor
        public ScoreController(IRepository repo, ILogger<ScoreController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // Methods

        // GET /api/score
        [HttpGet]
        public async Task<ActionResult<IEnumerable<score>>> GetScores()
        {
            IEnumerable<score> associates;

            try
            {
                associates = await _repo.GetScoreAsync();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return StatusCode(500);
            }

            return associates.ToList();
        }
    }
}
