
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;
using Core.BUM.Services;
using Core.BUM.Repository;

namespace Service.BUM
{
    public class TasksService : ITasksService
    {
        private readonly ITasksRepository _TasksRepository;
        public TasksService(ITasksRepository TasksRepository)
        {
            _TasksRepository = TasksRepository;
        }
        public void Delete(int id)
        {
         
        }

        public List<Tasks> GetCompleted()
        {
            return _TasksRepository.GetCompleted();
        }

        //public Professionals GetProfessional(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Tasks> GetUnCompleted()
        {
            return _TasksRepository.GetUnCompleted();
        }

        public Tasks Post(Tasks task)
        {
            return _TasksRepository.Post(task);
        }

        public Tasks Put(Tasks task)
        {
            return _TasksRepository.Put(task);
        }
    }
}
