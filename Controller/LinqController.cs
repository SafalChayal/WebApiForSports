using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSportsAPI.Models;

namespace WebSportsAPI.Controller
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LinqController : ControllerBase
    {
       
        private readonly MainDbContext _mainDbContext;
       

        public LinqController(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;

        }
        [HttpGet]
        public IActionResult GetTogether()
        {
            var q = (from s in _mainDbContext.Sports
                     join pd in _mainDbContext.Players on s.Sport_Id equals pd.Sport_Id
                     orderby s.Sport_Id
                     select new
                     {
                        
                         s.Sport_Name,
                         s.Sport_Team_Name,
                         //pd.Player_Id,
                         pd.PLayer_Name,
                         //pd.Player_Age,
                         //pd.Player_Country
                     }).ToList();

            return Ok(q);

        }

        [HttpGet("{id}")]
        public IActionResult GetCount(int id)
        {
            var q = (from s in _mainDbContext.Sports
                     join pd in _mainDbContext.Players on s.Sport_Id equals pd.Sport_Id
                     group pd by s.Sport_Id into g
                     orderby g.Key
                     select new
                     {
                         Sport_Id = g.Key,
                         PlayerCount = g.Count()
                     }).ToList();

            return Ok(q);
        }
    }
}
