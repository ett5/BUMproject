using Core.BUM.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Core.BUM.Entitis;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace api.BUM.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
       
    public class TasksController : ControllerBase
    {
        private readonly ITasksService _TasksService;
        public TasksController(ITasksService TasksService)
        {
            _TasksService = TasksService;
        }
        // GET : api/<TasksController>
        [HttpGet]
        public List<Tasks> GetCompleted()
        {
            return _TasksService.GetCompleted();
        }

        // GET : api/<TasksController>
        //[HttpGet]
        //public List<Tasks> GetUnCompleted()
        //{
        //    return _TasksService.GetUnCompleted();
        //}

        // GET api/<TasksController>/5
        //[HttpGet("{id}")]
        //public Tasks Get(int id)
        //{
        //    return _TasksService.GetProfessional(id);
        //}

        // POST api/<TasksController>
        [HttpPost]
        public Tasks Post([FromBody] Tasks task)
        {
           return _TasksService.Post(task);
        }

        // PUT api/<TasksController>/5
        //[HttpPut("{id}")]
        //public Tasks Put( [FromBody] Tasks task)
        //{
        //    return _TasksService.Put( task);
        //}

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _TasksService.Delete(id);   
        }
    }
}
