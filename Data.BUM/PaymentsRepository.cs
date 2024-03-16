using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;
using Core.BUM.Repository;

namespace Data.BUM
{

    public class PaymentsRepository : IPaymentsRepository
    {
        private readonly DataContexst _DataContexst;
        public PaymentsRepository(DataContexst DataContexst)
        {
            _DataContexst = DataContexst;
        }
        public Neighbors GetById(int id)
        {
            return _DataContexst.NeighborsList.Find(id);
        }
        public List<Payments> GetPayments()
        {
            return _DataContexst.PaymentsList.ToList(); 
        }
        //פוקציה לשימוש פנימי
        public List<Neighbors> payNeighbors(Boolean fla)
        {
            //לשלוף רק את העמודה של השכנים 

            HashSet<Neighbors> neighbors = new HashSet<Neighbors>();

            //neighbors.Add(GetPayments().Where(p => p.IsPaymetnet == fla).ToHashSet());
              
           return neighbors.ToList();




        }

        public List<Neighbors> GetPayNeighbors()
        {
            return payNeighbors(true);
        }

        public List<Neighbors> GetUnPayNeighbors()
        {
              return payNeighbors(false);
        }

        public Payments Post(Payments NewPayment)
        {
            GetPayments().Add(NewPayment);
            _DataContexst.SaveChanges();
            return NewPayment;
        }

        public List<Payments> Put(Neighbors NewNeighbor)
        {
            var neighbor = GetById(NewNeighbor.Id);
           
              List<Payments> p = GetPayments().Where( a=>a.Neighbors.Id==NewNeighbor.Id).ToList();
                for (int i = 0; i <= p.Count; i++)
                {
                    p[i].IsPaymetnet = true;
                }
                return p;
            
            
        }
    }
}
