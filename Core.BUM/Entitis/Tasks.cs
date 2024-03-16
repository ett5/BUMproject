using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Entitis
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Description { get; set; }//תיאור ספציפי של המשימה בנוסף לנושא הכללי
        public string Type { get; set; }    //תואם לסוגים בטבלת מקצועות
        public float Cost { get; set; }
        public bool IsCompleted { get; set; }
        public Professionals Professional { get; set; }
        public int ProfessionalsId { get; set; }    
        public Revenues Revenues { get; set; }
    }
}
