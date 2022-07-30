using Computer_Club.Model.DataBaseModels;
using Computer_Club.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Computer_Club.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        IComputer _computer;
        public ComputerController(IComputer computer)
        {
            _computer = computer;
        }

        // GET: api/<ComputerController>
        [HttpGet]
        public ActionResult<IEnumerable<Computer>> GetComputers()
        {
            return Ok(_computer.GetComputers());
        }

        // GET api/<ComputerController>/5
        [HttpGet("{id}")]
        public ActionResult<Computer>GetComputer(int id)
        {
           var computers = _computer.GetComputer(id);
            if (true)
            {
                if (computers == null)
                {
                    return NotFound();
                }
                return Ok(computers);
            }
        }

        // POST api/<ComputerController>
        [HttpPost]
        public IActionResult PostComputer(Computer computer)
        {
            _computer.Create(computer);
            return Ok();
        }

        // PUT api/<ComputerController>/5
        [HttpPut("{id}")]
        public IActionResult PutComputer(int id, Computer computer)
        {
            if (id != computer.Id)
            {
                return BadRequest("Id computer not found");
            }
            _computer.Update(id,computer);
            return Ok();
        }

        // DELETE api/<ComputerController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteComputer(int id)
        {
            _computer.Delete(id);
            return Ok();
        }
    }
}
