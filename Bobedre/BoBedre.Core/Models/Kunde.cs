using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Kunde : IPerson
    {
        public Kunde(int kundeNr, string navn, string email, string type)
        {
            KundeNr = kundeNr;
            Navn = navn;
            Email = email;
            Type = type;
        }

        public int KundeNr { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }

        /// <summary>
        /// Create a kunde object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Kunde CreateKundeFromData(object[] values)
        {
            if (values == null)
            {
                return null;
            }
            else if (values.Length == typeof(Kunde).GetProperties().Length)
            {
                return new Kunde(
                (int)values[0],
                (string)values[1],
                (string)values[2],
                (string)values[3]
                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }
        }
    }
}
