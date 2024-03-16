using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BUM.Entitis
{
    public class Neighbors
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public int ApartmentNum { get; set; }
        public int NumPersons { get; set; }
        public bool Profil { get; set; }//אפס זה מנהל ואחד זה שכן
        public List<Payments> Payments { get; set; }
        public List<Messages> Messages { get; set; }
    }
}
