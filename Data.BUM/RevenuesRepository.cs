
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;
using Core.BUM.Repository;

namespace Data.BUM
{
    public class RevenuesRepository : IRevenuesRepository
    {
        private readonly DataContexst _DataContexst;
        public RevenuesRepository(DataContexst DataContexst)
        {
            _DataContexst = DataContexst;
        }
        public List<Revenues> GetRevenues()
        {
            return _DataContexst.RevenuesList.ToList();
        }

        public List<Revenues> GetRevenuesUpCost(int cost)

        {
            return GetRevenues().Where(a => a.Expense.Cost >= cost).ToList();
                
        }

        public Revenues GetRevenueByTask(Revenues t)
        {
            List<Revenues>revenues=GetRevenues();
            Revenues revenue =revenues[0];
            //int count = 1;
            //while (revenue.Expense != task)
            //{
            //     count++;
            //    revenue = revenues[count];
               
            //}
          return revenue; 
        }

        public Revenues Post(Tasks Revenue)
        {
            //_DataContexst.RevenuesList.Add(null, Revenue, 0, GetRevenues()[].Cashbox-Revenue.Cost);
            //Revenues revenue = GetRevenues()[GetRevenues().Count- 1];
            //return revenue;
            return null;
                }

        //public Revenues Put(Tasks Revenue) אולי לא צריך לעדכן??
        //{
        //    Revenues revenue = GetRevenueByTask(Revenue);
        //    if (revenue != null)
        //    {
        //        revenue.Expense = Revenue;
        //        int cnt=revenue.Expense
        //        revenue.Cashbox=
        //    }
        //}
       
        public float GetCashbox()
        {
            
            List < Revenues >revenues = GetRevenues();
            Revenues revenue=revenues[revenues.Count-1];
            return revenue.Cashbox;
        }

       
    }
}
