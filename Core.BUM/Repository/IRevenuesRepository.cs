using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.BUM.Entitis;

namespace Core.BUM.Repository
{
    public interface IRevenuesRepository
    {
        public List<Revenues> GetRevenues();
        public List<Revenues> GetRevenuesUpCost(int cost);//מחזיר את כל השורות שעלותם יותר מהמחיר ששלחו
      //  public Revenues Put(Tasks Revenue);
        public Revenues Post(Tasks Revenue);
        public float GetCashbox();
    }
}
