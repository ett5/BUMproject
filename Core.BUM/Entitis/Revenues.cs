using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Entitis
{
    public class Revenues
    {
        public int Id { get; set; } 
        public Tasks Expense { get; set; }    //הוצאות
        public Payments Pay { get; set; }//הכנסות
        public float Cashbox { get; set; }//סהכ בקופה
        public int TasksId { get; set; }
        public int PaymentsId { get; set; }

    }
}
