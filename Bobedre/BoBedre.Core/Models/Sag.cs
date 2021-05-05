using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Sag
    {
        public Sag(int sagNr, int? boligNr, int sælgerNr, int? køberNr, int medarbejderNr, DateTime oprettelsesDato, DateTime? tilSalgDato, bool solgt, int? gebyr, int? salær, DateTime? overdragelsesDato, DateTime? afslutningsDato)
        {
            SagNr = sagNr;
            BoligNr = boligNr;
            SælgerNr = sælgerNr;
            KøberNr = køberNr;
            MedarbejderNr = medarbejderNr;
            OprettelsesDato = oprettelsesDato;
            TilSalgDato = tilSalgDato;
            Solgt = solgt;
            Gebyr = gebyr;
            Salær = salær;
            OverdragelsesDato = overdragelsesDato;
            AfslutningsDato = afslutningsDato;
        }

        public int SagNr { get; set; }
        public int? BoligNr { get; set; }
        public int SælgerNr { get; set; }
        public int? KøberNr { get; set; }
        public int MedarbejderNr { get; set; }
        public DateTime OprettelsesDato { get; set; }
        public DateTime? TilSalgDato { get; set; }
        public bool Solgt { get; set; }
        public int? Gebyr { get; set; }
        public int? Salær { get; set; }
        public DateTime? OverdragelsesDato { get; set; }
        public DateTime? AfslutningsDato { get; set; }

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
                                (int?)values[1],
                                (int)values[2],
                                (int?)values[3],
                                (int)values[4],
                                (DateTime)values[5],
                                (DateTime)values[6],
                                (bool)values[7],
                                (int)values[8],
                                (int)values[9],
                                (DateTime)values[10],
                                (DateTime)values[11]
                                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }
    }
}
