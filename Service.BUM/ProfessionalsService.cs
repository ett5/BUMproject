
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
    public class ProfessionalsService : IProfessionalsService
    {
        private readonly IProfessionalsRepository _ProfessionalsRepository;
        public ProfessionalsService(IProfessionalsRepository ProfessionalsRepository)
        {
            _ProfessionalsRepository = ProfessionalsRepository;
        }
        public void Delete(int id)
        {
            _ProfessionalsRepository.Delete(id);    }

        public Professionals GetProfessional(int id)
        {
            return _ProfessionalsRepository.GetProfessional(id);       }

        public List<Professionals> GetProfessionals()
        {
            return _ProfessionalsRepository.GetProfessionals();       }

        public List<Professionals> GetProfessionalsByType(String type)
        {
            return _ProfessionalsRepository.GetProfessionalsByType(type);        }

        public Professionals Post(Professionals NewProfessional)
        {
            return _ProfessionalsRepository.Post(NewProfessional);        }

        public Professionals Put(Professionals Professional)
        {
            return _ProfessionalsRepository.Put(Professional);      }
    }
}
