using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Computer_Club.Model.DataBaseModels;
using Computer_Club.Services.Contracts;

namespace Computer_Club.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        IGame _game;
        public GameController(IGame game)
        {
            _game = game;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetGames()
        {
            return Ok(_game.GetGames());
        }

        [HttpGet("{id}")]
        public ActionResult<Game> GetGameById(int id)
        {
            var game = _game.GetGameById(id);
            if (true)
            {
                if (game == null)
                {
                    return NotFound();
                }
                return Ok(game);
            }
        }

        [HttpPost]
        public IActionResult PostGame(Game game)
        {
            _game.Create(game);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutGame(int id, Game game)
        {
            if (id != game.Id)
            {
                return BadRequest("Id computer not found");
            }
            _game.Update(id, game);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGame(int id)
        {
            _game.Delete(id);
            return Ok();
        }

    }
}
