using Core.BUM.Entitis;
using Core.BUM.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace api.BUM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NeighborsController : ControllerBase
    {

        private readonly INeighborsService _NeighborsService;
        public NeighborsController(INeighborsService NeighborsService)
        {
            _NeighborsService = NeighborsService;
        }
        // GET: api/<NeighborsController>
        [HttpGet]
        public List<Neighbors> Get()
        {
            return _NeighborsService.GetNeighbors();
        }

        // GET api/<NeighborsController>/5
        [HttpGet("{id}")]
        public Neighbors Get(int id)
        {
            return _NeighborsService.GetNeighbor(id);     
        }

        // POST api/<NeighborsController>
        [HttpPost]
        public Neighbors Post([FromBody] Neighbors Neighbor)
        {
            return _NeighborsService.Post(Neighbor);
        }

        //// PUT api/<NeighborsController>/5
        //[HttpPut("{id}")]
        //public Neighbors Put( [FromBody] Neighbors Neighbor)
        //{
        //    return _NeighborsService.Put(Neighbor);
        //}

        // DELETE api/<NeighborsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
             _NeighborsService.Delete(id);
        }
    }
}
