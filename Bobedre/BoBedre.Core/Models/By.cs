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

        /// <summary>
        /// Creates a by object from object data
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static By CreateByFromData(object[] values)
        {
            if (values == null)
            {
                return null;
            }
            else if (values.Length == typeof(By).GetProperties().Length)
            {
                return new By(
                (int)values[0],
                (string)values[1]
                );
            }
            else
            {
                throw new ArgumentOutOfRangeException("values", "values datapoints don't match model");
            }

        }
    }
}
