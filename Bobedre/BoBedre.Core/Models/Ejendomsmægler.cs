using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Ejendomsmægler : IPerson
    {
        public Ejendomsmægler(int medarbejderNr, string afdeling, string mæglerfirma, string navn, string email)
        {
            MedarbejderNr = medarbejderNr;
            Afdeling = afdeling;
            Mæglerfirma = mæglerfirma;
            Navn = navn;
            Email = email;
        }

        public int MedarbejderNr { get; set; }
        public string Afdeling { get; set; }
        public string Mæglerfirma { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
    }
}
