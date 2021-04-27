using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Sag
    {
        public Sag(int sagNr, int boligNr, int sælgerNr, int køberNr, int medarbejderNr)
        {
            SagNr = sagNr;
            BoligNr = boligNr;
            SælgerNr = sælgerNr;
            KøberNr = køberNr;
            MedarbejderNr = medarbejderNr;
        }

        public int SagNr { get; set; }
        public int BoligNr { get; set; }
        public int SælgerNr { get; set; }
        public int KøberNr { get; set; }
        public int MedarbejderNr { get; set; }
    }
}
