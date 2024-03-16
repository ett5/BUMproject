using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Entitis
{
    public class Professionals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }//נכניס בהתחלה מספר מספר אפשרויות ללא שינוי ויהיה גם אופציה לאחר
        public string Phone { get; set; }

        List<Tasks> Tasks { get; set; }  
    }
}
