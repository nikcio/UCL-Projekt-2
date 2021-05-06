using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Sag
    {
        public Sag(int sagNr, DateTime oprettelsesDato, DateTime? tilSalgDato, bool solgt, int? gebyr, int? salær, DateTime? overdragelsesDato, DateTime? afslutningsDato, int? boligNr, int sælgerNr, int? køberNr, int medarbejderNr)
        {
            SagNr = sagNr;
            OprettelsesDato = oprettelsesDato;
            TilSalgDato = tilSalgDato;
            Solgt = solgt;
            Gebyr = gebyr;
            Salær = salær;
            OverdragelsesDato = overdragelsesDato;
            AfslutningsDato = afslutningsDato;
            BoligNr = boligNr;
            SælgerNr = sælgerNr;
            KøberNr = køberNr;
            MedarbejderNr = medarbejderNr;
        }

        public int SagNr { get; set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime? TilSalgDato { get; set; }
        public bool Solgt { get; set; }
        public int? Gebyr { get; set; }
        public int? Salær { get; set; }
        public DateTime? OverdragelsesDato { get; set; }
        public DateTime? AfslutningsDato { get; set; }
        public int? BoligNr { get; set; }
        public int SælgerNr { get; set; }
        public int? KøberNr { get; set; }
        public int MedarbejderNr { get; set; }

        /// <summary>
        /// Create sag object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Sag CreateSagFromData(object[] values)
        {
            if (values == null)
            {
                return null;
            }
            else if (values.Length == typeof(Sag).GetProperties().Length)
            {
                return new Sag(
                                (int)values[0],
                                (DateTime)values[1],
                                (DateTime)values[2],
                                (bool)values[3],
                                (int)values[4],
                                (int)values[5],
                                (DateTime)values[6],
                                (DateTime)values[7],
                                (int?)values[8],
                                (int)values[9],
                                (int?)values[10],
                                (int)values[11]
                                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }
    }
}
