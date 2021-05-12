using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Logic
{
    public static class Statistik
    {
        public static async Task<List<Ejendom>> GetEjendommeStatisk(int medarbejderNr, DateTime startDate, DateTime endDate, int postNr, int[] range)
        {
            var sager = await Fetch.GetSagAll();

            var sagerSolgt = sager.Where(item =>
                item.Solgt == true &&
                item.MedarbejderNr == medarbejderNr &&
                ItemWitinDate(item, startDate, endDate)
            );

            var ejendomme = await Fetch.GetEjenommeByBoligNr(sagerSolgt.Select(item => item.BoligNr.GetValueOrDefault()).ToArray());

            var ejendommeStatisk = ejendomme.Where(item =>
                item.PostNr == postNr &&
                ItemWithinPrice(item, range)
            );
            return ejendommeStatisk.ToList();
        }

        private static bool ItemWitinDate(Sag sag, DateTime startDate, DateTime endDate)
        {
            if (sag.AfslutningsDato != null)
            {
                return startDate.Ticks <= sag.AfslutningsDato.GetValueOrDefault().Ticks && sag.AfslutningsDato.GetValueOrDefault().Ticks <= endDate.Ticks;
            }
            else
            {
                return false;
            }
        }

        private static bool ItemWithinPrice(Ejendom ejendom, int[] range)
        {
            if (range.Length != 2)
            {
                throw new ArgumentOutOfRangeException("range", "A price must only have a min and max value");
            }
            return range[0] <= ejendom.Pris && ejendom.Pris <= range[1];
        }
    }
}
