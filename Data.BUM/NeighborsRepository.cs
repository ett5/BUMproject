using Core.BUM.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;

namespace Data.BUM
{
    public class NeighborsRepository : INeighborsRepository
    {
        private readonly DataContexst _DataContexst;
        public NeighborsRepository(DataContexst DataContexst)
        {
            _DataContexst = DataContexst;
        }
         public Neighbors GetById(int id)
        {
            return _DataContexst.NeighborsList.Find(id);
        }
       
        public void Delete(int id)
        {
            var neighbor=GetById(id);
            _DataContexst.NeighborsList.Remove(neighbor);
            _DataContexst.SaveChanges();    
        }

        public Neighbors GetNeighbor(int id)
        {
           return GetById(id);
        }

        public List<Neighbors> GetNeighbors()
        {
            return _DataContexst.NeighborsList.ToList();
        }

        public Neighbors Post(Neighbors NewNeighbor)
        {
            _DataContexst.NeighborsList.Add(NewNeighbor);
            _DataContexst.SaveChanges();
            return NewNeighbor;    
                }

        public Neighbors Put(Neighbors NewNeighbor)
        {
            var neighbor = GetById(NewNeighbor.Id);
            neighbor.ApartmentNum = NewNeighbor.ApartmentNum;
            neighbor.NumPersons = NewNeighbor.NumPersons;
            neighbor.LastName = NewNeighbor.LastName;
            _DataContexst.SaveChanges();
            return neighbor;
        }
    }
}
