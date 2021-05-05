using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Renorvering
    {
        public Renorvering(int renorveringsId, bool køkken, bool badeværelse, bool andet, int ombygningsår, string detaljer, int boligNr)
        {
            RenorveringsId = renorveringsId;
            Køkken = køkken;
            Badeværelse = badeværelse;
            Andet = andet;
            Ombygningsår = ombygningsår;
            Detaljer = detaljer;
            BoligNr = boligNr;
        }

        public int RenorveringsId { get; set; }
        public bool Køkken { get; set; }
        public bool Badeværelse { get; set; }
        public bool Andet { get; set; }
        public int Ombygningsår { get; set; }
        public string Detaljer { get; set; }
        public int BoligNr { get; set; }

        /// <summary>
        /// Create renorverings object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Renorvering CreateRenorveringFromData(object[] values)
        {
            if (values == null)
            {
                return null;
            }
            else if (values.Length == typeof(Renorvering).GetProperties().Length)
            {
                return new Renorvering(
                (int)values[0],
                (bool)values[1],
                (bool)values[2],
                (bool)values[3],
                (int)values[4],
                (string)values[5],
                (int)values[6]
                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }
    }
}
