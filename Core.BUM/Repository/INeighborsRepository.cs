using Core.BUM.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Repository
{
    public interface INeighborsRepository
    {
        public List<Neighbors> GetNeighbors();
        public Neighbors GetNeighbor(int id);
        public void Delete(int id);
        public Neighbors Put(Neighbors NewNeighbor);
        public Neighbors Post(Neighbors NewNeighbor);
    }
}
