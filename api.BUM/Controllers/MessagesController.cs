
using Core.BUM.Services;
using Core.BUM.Entitis;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace api.BUM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {

        private readonly IMessagesService _MessagesService;
        public MessagesController(IMessagesService MessagesService)
        {
            _MessagesService = MessagesService;
        }
        // GET: api/<MessagesController>
        [HttpGet]
        public List<Messages> Get()
        {
            return _MessagesService.GetMessages();
        }

        // GET api/<MessagesController>/5
        //[HttpGet("{date}")]
        //public List<Messages> GetUntilDate(DateTime date)
        //{
        //    return _MessagesService.GetMessagesUntilDate(date);
        //}

        //// GET api/<MessagesController>/5
        //[HttpGet("{FromDate}")]
        //public List<Messages> GetFromDate(DateTime Date)
        //{
        //    return _MessagesService.GetMessagesFromDate(Date);
        //}

        //// GET api/<MessagesController>/5
        //[HttpGet("{BetweenDates}")]
        //public List<Messages> GetBetweenDates(DateTime Start, DateTime End)
        //{
        //    return _MessagesService.GetMessagesBetweenDates(Start, End);    
        //}

        //[HttpGet("{ByDate}")]
        //public List<Messages> GetByDate(DateTime Date)
        //{
        //    return _MessagesService.GetMessagesByDate(Date);
        //}
        //[HttpGet("{FromNeighbor}")]
        //public List<Messages> GetMessagesFromneighbor(Neighbors neighbor)
        //{
        //    return _MessagesService.GetMassageesFromNeighbor(neighbor);
        //}
        //[HttpGet("{ToNeighbors}")]
        //public List<Messages> GetMessagesToneighbor(Neighbors neighbor)
        //{
        //    return _MessagesService.GetMassageesToNeighbor(neighbor);


        // POST api/<MessagesController>
        [HttpPost]
        public Messages Post([FromBody] Messages message)
        {
            return _MessagesService.Post(message);
        }

        //// PUT api/<MessagesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TasksController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
