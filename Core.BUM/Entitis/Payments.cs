using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Entitis
{
    public class Payments
    {
        public int Id { get; set; }
        public Neighbors Neighbors { get; set; }
        public int NeighborsId { get; set; }
        public bool IsPaymetnet { get; set; }
        public DateOnly Date { get; set; }
        public float Cost { get; set; }
        public Revenues Revenues { get; set; }  
        
        
        //להוסיף משתנה משתנה יינם לאמצעי תשלום

    }
}
