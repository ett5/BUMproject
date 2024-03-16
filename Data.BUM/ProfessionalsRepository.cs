

using Core.BUM.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.BUM;
using Core.BUM.Entitis;


namespace Data.BUM
{
    public class ProfessionalsRepository : IProfessionalsRepository
    {
        private readonly DataContexst _DataContexst;
        public ProfessionalsRepository(DataContexst DataContexst)
        {
            _DataContexst = DataContexst;
        }
        public Professionals GetById(int id)
        {
            return _DataContexst.ProfessionalsList.Find(id);
        }

        public void Delete(int id)
        {
            var Professional = GetById(id);
            _DataContexst.Remove(Professional);
            _DataContexst.SaveChanges(); 
        }

        public Professionals GetProfessional(int id)
        {
            return GetById(id);
        }

        public List<Professionals> GetProfessionals()
        {
            return _DataContexst.ProfessionalsList.ToList();
        }

        public List<Professionals> GetProfessionalsByType(String type)
        {
            List <Professionals> professionals=_DataContexst.ProfessionalsList.Where(a=>a.Type == type).ToList();   
            return professionals;
        }

        public Professionals Post(Professionals NewProfessional)
        {
            _DataContexst.ProfessionalsList.Add(NewProfessional);
            _DataContexst.SaveChanges();
            return NewProfessional;
        }

        public Professionals Put(Professionals NewProfessional)
        {
            var Professional = GetById(NewProfessional.Id);
            Professional.Name = NewProfessional.Name;
            Professional.Phone = NewProfessional.Phone;
            _DataContexst.SaveChanges();
            return Professional;

        }
    }
}
