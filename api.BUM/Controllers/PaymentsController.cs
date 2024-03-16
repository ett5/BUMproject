using Core.BUM.Services;
using Microsoft.AspNetCore.Mvc;
using Core.BUM.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace api.BUM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentsService _PaymentsService;
        public PaymentsController(IPaymentsService PaymentsService)
        {
            _PaymentsService = PaymentsService;
        }
        // GET: api/<PaymentsController>
        [HttpGet]
        public List<Payments> GetpayNeighbors()
        {
            return _PaymentsService.GetpayNeighbors();
        }
        //// GET: api/<PaymentsController>
        //[HttpGet]
        //public List<Payments> GetUnPayNeighbors()
        //{
        //    // return _PaymentsService.GetUnPayNeighbors().ToList();
        //    return null;
        //}
        // GET api/<PaymentsController>/5
        [HttpGet("{id}")]
        public Payments Get(int id)
        {
            return _PaymentsService.GetById(id);
        }

        // POST api/<PaymentsController>
        [HttpPost]
        public void Post([FromBody] Payments value)
        {
            _PaymentsService.Post(value);   
        }

        //// PUT api/<PaymentsController>/5
        //[HttpPut("{id}")]
        //public void Put( [FromBody] Payments value)
        //{
        //   // _PaymentsService.Put(value);    
        //}

       
    }
}
