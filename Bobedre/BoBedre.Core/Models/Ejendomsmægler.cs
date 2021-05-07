using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public class Ejendomsmægler : IPerson
    {
        public Ejendomsmægler(int medarbejderNr, string afdeling, string mæglerfirma, string navn, string email)
        {
            MedarbejderNr = medarbejderNr;
            Afdeling = afdeling;
            Mæglerfirma = mæglerfirma;
            Navn = navn;
            Email = email;
        }

        public int MedarbejderNr { get; set; }
        public string Afdeling { get; set; }
        public string Mæglerfirma { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// Creates a ejendomsmægler object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static Ejendomsmægler CreateEjendomsmæglerFromData(object[] values)
        {
            if (values == null)
            {
                return null;
            }
            else if (values.Length == typeof(Ejendomsmægler).GetProperties().Length)
            {
                return new Ejendomsmægler(
                                (int)values[0],
                                (string)values[1],
                                (string)values[2],
                                (string)values[3],
                                (string)values[4]
                                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }

        }
    }
}
