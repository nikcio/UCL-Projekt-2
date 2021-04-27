using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Renorvering
    {
        public int RenorveringsId { get; set; }
        public bool Køkken { get; set; }
        public bool Badeværelse { get; set; }
        public bool Andet { get; set; }
        public int Ombygningsår { get; set; }
        public string Detaljer { get; set; }
        public int BoligNr { get; set; }
    }
}
