
using Core.BUM.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;

namespace Data.BUM
{
    public class TasksRepository : ITasksRepository
    {
        private readonly DataContexst _DataContexst;
        public TasksRepository(DataContexst DataContexst)
        {
            _DataContexst = DataContexst;
        }
        public Tasks GetById(int id)
        {
            return _DataContexst.TaskList.Find(id);
        }
        public void Delete(int id)
        {
            var Task = GetById(id);
            _DataContexst.Remove(Task);
            _DataContexst.SaveChanges();
        }


        public List<Tasks> GetCompleted()
        {
            return _DataContexst.TaskList.Where(a => a.IsCompleted == true).ToList();
        }

        //public Professionals GetProfessional(int id)
        //{
        //    return _DataContexst.;
        //}

        public List<Tasks> GetUnCompleted()
        {
            return _DataContexst.TaskList.Where(a => a.IsCompleted == false).ToList();
        }

        public Tasks Post(Tasks task)
        {
            _DataContexst.TaskList.Add(task);
            _DataContexst.SaveChanges();
            return task;
        
            
        }

        public Tasks Put( Tasks task)
        {
            var newTask = GetById(task.Id);
            newTask.IsCompleted = task.IsCompleted;
            newTask.Cost = task.Cost;
            newTask.Type = task.Type;
            _DataContexst.SaveChanges();
            return task;
        }
    }
}

