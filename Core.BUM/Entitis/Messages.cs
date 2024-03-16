using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Entitis
{
    public class Messages
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Neighbors To { get; set; }
        public Neighbors From { get; set; }
        public DateTime Start { get; set; } 
        public DateTime End { get; set; }   
        public List <Neighbors> Neighbors { get; set; }
    }
}
