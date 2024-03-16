using Core.BUM.Services;
using Microsoft.AspNetCore.Mvc;
using Core.BUM.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace api.BUM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionalsController : ControllerBase
    {

        private readonly IProfessionalsService _ProfessionalsService;
        public ProfessionalsController(IProfessionalsService ProfessionalsService)
        {
            _ProfessionalsService = ProfessionalsService;
        }
        // GET: api/<ProfessionalsController>
        [HttpGet]
        public List<Professionals> Get()
        {
            return _ProfessionalsService.GetProfessionals();
        }

        //// GET api/<ProfessionalsController>/5
        //[HttpGet("{type}")]
        //public List<Professionals> Get(String type)
        //{
        //    return _ProfessionalsService.GetProfessionalsByType(type);
        //}
        // GET api/<ProfessionalsController>/5
        [HttpGet("{id}")]
        public Professionals GetById(int id )
        {
            return _ProfessionalsService.GetProfessional(id);
        }
        // POST api/<ProfessionalsController>
        [HttpPost]
        public Professionals Post([FromBody] Professionals Professionals)
        {
            return _ProfessionalsService.Post(Professionals);
        }

        // PUT api/<ProfessionalsController>/5
        //[HttpPut("{id}")]
        //public Professionals Put( Professionals Professionals)
        //{
        //    return _ProfessionalsService.Put(Professionals);
        //}

        // DELETE api/<ProfessionalsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ProfessionalsService.Delete(id);   
        }
    }
}
