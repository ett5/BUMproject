
using Core.BUM.Entitis;
using Core.BUM.Services;
using Core.BUM.Repository;

namespace Service.BUM
{
    public class NeighborsService : INeighborsService
    {
        private readonly INeighborsRepository _NeighborsRepository;
        public NeighborsService(INeighborsRepository NeighborsRepository)
        {
            _NeighborsRepository = NeighborsRepository;
        }
        public void Delete(int id)
        {
             _NeighborsRepository.Delete(id);  }

        public Neighbors GetNeighbor(int id)
        {
            return _NeighborsRepository.GetNeighbor(id);
        }

        public List<Neighbors> GetNeighbors()
        {
            return _NeighborsRepository.GetNeighbors();
        }

        public Neighbors Post(Neighbors NewNeighbor)
        {
            return _NeighborsRepository.Post(NewNeighbor);
        }

        public Neighbors Put(Neighbors NewNeighbor)
        {
            return _NeighborsRepository.Put(NewNeighbor);        }
    }
}
