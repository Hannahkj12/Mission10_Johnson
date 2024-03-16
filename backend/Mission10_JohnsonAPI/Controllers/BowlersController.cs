using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_JohnsonAPI.Data;

namespace Mission10_JohnsonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlersController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlersController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        //public IEnumerable<Bowler> Get()
        public IEnumerable<object> Get()
        {
            return _bowlerRepository.GetBowlerTeams();
        }
    }
}


//var bowlerData = _bowlerRepository.Bowlers.ToArray();
//return bowlerData;