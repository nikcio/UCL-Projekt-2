using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Kunde : IPerson
    {
        public Kunde(int kundeNr, string navn, string email, string type)
        {
            KundeNr = kundeNr;
            Navn = navn;
            Email = email;
            Type = type;
        }

        public int KundeNr { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
    }
}
