using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;


namespace Core.BUM.Repository
{
    public interface ITasksRepository
    {
        public List<Tasks> GetCompleted();
        public List<Tasks> GetUnCompleted();
       // public Professionals GetProfessional(int id);
        public void Delete(int id);
        public Tasks Put(Tasks task);//לשים לב שלא ניתן לעדכן סוג משימה חדש
        public Tasks Post(Tasks task);//לא לאפשר הוספה של סוג משימה חדש
    }
}
