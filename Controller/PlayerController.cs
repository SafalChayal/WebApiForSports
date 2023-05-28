using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSportsAPI.Models;
using WebSportsAPI.SportRepository;

namespace WebSportsAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayers _Iplayerrepo;

        public PlayerController(PlayerClass plc)
        {
            _Iplayerrepo = plc;
        }

        [HttpPost]
        public ActionResult AddPlayer(Player model)
        {
            if (ModelState.IsValid)
            {
                _Iplayerrepo.Insert(model);
                //To make the changes permanent in the database, call the Save method of EmployeeRepository
                _Iplayerrepo.Save();

            }
            //If the Model state is not valid, then stay on the current AddEmployee view
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var player = _Iplayerrepo.GetPlayers();
            return Ok(player);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) {

            var player = _Iplayerrepo.GetPlayers();
            return Ok(player);
        }

        [HttpDelete]

        public IActionResult DeleteById(int id)
        {
            var player = _Iplayerrepo.Delete(id);
            return Ok(player);
        }
    }
}
