using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class By
    {
        public By(int postNr, string byNavn)
        {
            PostNr = postNr;
            ByNavn = byNavn;
        }

        public int PostNr { get; set; }
        public string ByNavn { get; set; }
    }
}
