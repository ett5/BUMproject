
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
    public class RevenuesService : IRevenuesService
    {
        private readonly IRevenuesRepository _RevenuesRepository;
        public RevenuesService(IRevenuesRepository RevenuesRepository)
        {
            _RevenuesRepository = RevenuesRepository;
        }
        public List<Revenues> GetRevenues()
        {
            return _RevenuesRepository.GetRevenues();
        }

        public List<Revenues> GetRevenuesUpCost(int cost)
        {
            return _RevenuesRepository.GetRevenuesUpCost(cost);
        }

        public Revenues Post(Tasks Revenue)
        {
            if (GetHashCode() - Revenue.Cost < 0)
                return null;
            else
                _RevenuesRepository.Post(Revenue);
            return _RevenuesRepository.GetRevenues()[_RevenuesRepository.GetRevenues().Count-1];
        }

        public Revenues Put(Tasks Revenue)
        {
            // return _RevenuesRepository.Put(Revenue);
            return null;
        }
        public int GetCashBox()
        {
            return 1;
                ///_RevenuesRepository.GetCashbox();
        }
    }
}
