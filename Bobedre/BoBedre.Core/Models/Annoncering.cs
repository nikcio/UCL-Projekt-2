using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Annoncering
    {
        public Annoncering(int annonceringsNr, string type, DateTime startDato, DateTime slutDato, int sagNr)
        {
            AnnonceringsNr = annonceringsNr;
            Type = type;
            StartDato = startDato;
            SlutDato = slutDato;
            SagNr = sagNr;
        }

        public int AnnonceringsNr { get; set; }
        public string Type { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }
        public int SagNr { get; set; }

        /// <summary>
        /// Create a annoncering object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Annoncering CreateAnnonceringFromData(object[] values)
        {
            if (values == null)
            {
                return null;
            }
            else if (values.Length == typeof(Annoncering).GetProperties().Length)
            {
                return new Annoncering(
                (int)values[0],
                (string)values[1],
                (DateTime)values[2],
                (DateTime)values[3],
                (int)values[4]
                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }
    }
}
