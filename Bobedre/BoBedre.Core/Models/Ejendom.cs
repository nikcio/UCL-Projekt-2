using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Ejendom
    {
        public Ejendom(int boligNr, string adresse, int pris, int boligAreal, int? grundAreal, int værelser, int? etager, int byggeår, bool have, string type, int postNr)
        {
            BoligNr = boligNr;
            Adresse = adresse;
            Pris = pris;
            BoligAreal = boligAreal;
            GrundAreal = grundAreal;
            Værelser = værelser;
            Etager = etager;
            Byggeår = byggeår;
            Have = have;
            Type = type;
            PostNr = postNr;
        }

        public int BoligNr { get; set; }
        public string Adresse { get; set; }
        public int Pris { get; set; }
        public int BoligAreal { get; set; }
        public int? GrundAreal { get; set; }
        public int Værelser { get; set; }
        public int? Etager { get; set; }
        public int Byggeår { get; set; }
        public bool Have { get; set; }
        public string Type { get; set; }
        public int PostNr { get; set; }
    }
}
