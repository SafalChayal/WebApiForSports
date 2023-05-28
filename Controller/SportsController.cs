using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSportsAPI.Models;
using WebSportsAPI.SportRepository;

namespace WebSportsAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SportsController : ControllerBase
    {
        private readonly ISports _ISportRepo;

        public SportsController(SportClass sct)
        {
            _ISportRepo = sct;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var sport = _ISportRepo.GetSports();
            return Ok(sport);
        }

        [HttpPost]
        public ActionResult AddSport(Sport model)
        {
            if (ModelState.IsValid)
            {
                _ISportRepo.Insert(model);
                //To make the changes permanent in the database, call the Save method of EmployeeRepository
                _ISportRepo.Save();
               
            }
            //If the Model state is not valid, then stay on the current AddEmployee view
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var sport = _ISportRepo.GetById(id);
            if (sport == null)
            {
                return NotFound();
            }

            return Ok(sport);
        }

        [HttpDelete]
        public IActionResult DeleteById(int id)
        {
            var sport =   _ISportRepo.Delete(id);

            return Ok(sport);

        }

        [HttpPut]
        public void Put(Sport sport)
        {
             _ISportRepo.Update(sport);
             

        }
    }
}