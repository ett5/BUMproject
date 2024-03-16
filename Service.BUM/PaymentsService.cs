
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.BUM.Entitis;
using Core.BUM.Services;
using Core.BUM.Repository;

namespace Service.BUM
{
    public class PaymentsService :IPaymentsService
    {

        private readonly IPaymentsRepository _PaymentsRepository;
    public PaymentsService(IPaymentsRepository PaymentsRepository)
    {
        _PaymentsRepository = PaymentsRepository;
    }

        public Payments GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Neighbors> GetPayNeighbors()
        {
            return _PaymentsRepository.GetPayNeighbors();    }

        public List<Payments> GetpayNeighbors()
        {
            throw new NotImplementedException();
        }

        public List<Neighbors> GetUnPayNeighbors()
        {
            return _PaymentsRepository.GetUnPayNeighbors();
        }

        public Payments Post(Payments Payment)
        {
            return _PaymentsRepository.Post(Payment);          }

        public List<Payments> Put(Neighbors NewNeighbor)
        {
            if(NewNeighbor != null)
            return _PaymentsRepository.Put(NewNeighbor);

            return null;
        }
    }
}
