
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;

namespace Core.BUM.Services
{
    public interface ITasksService
    {
        public List<Tasks> GetCompleted();
        public List<Tasks> GetUnCompleted();
        //public Professionals GetProfessional(int id);
        public void Delete(int id);
        public Tasks Put(Tasks task);
        public Tasks Post(Tasks task);
    }
}
