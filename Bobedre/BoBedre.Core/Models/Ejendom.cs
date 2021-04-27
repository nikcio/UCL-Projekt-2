using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Ejendom
    {
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
