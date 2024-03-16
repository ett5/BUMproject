using Core.BUM.Services;
using Microsoft.AspNetCore.Mvc;
using Core.BUM.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace api.BUM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenuesController : ControllerBase
    {
        private readonly IRevenuesService _RevenuesService;
        public RevenuesController(IRevenuesService RevenuesService)
        {
            _RevenuesService = RevenuesService;
        }
        // GET: api/<RevenuesController>
        [HttpGet]
        public List<Revenues> Get()
        {
            return _RevenuesService.GetRevenues();
        }

        // GET api/<RevenuesController>/5
        //[HttpGet("{id}")]
        //public List<Revenues> Get(int coust)
        //{
        //    return _RevenuesService.GetRevenuesUpCost(coust);
        //}

        // POST api/<RevenuesController>
        [HttpPost]
        public void Post([FromBody] Task value)
        {
           // _RevenuesService.Post(value);    
        }
        //צריך לבדוק אם עושים put 
        // PUT api/<RevenuesController>/5
        //[HttpPut("{id}")]
        //public void Put( [FromBody] Revenues value)
        //{
        //   _RevenuesService.PutRevenue(value);  
        //}

      
        
    }
}
