using BoBedre.Core.AssetLoaders;
using BoBedre.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Logic
{
    public static class PrisBeregning
    {
        public static async Task<int> Beregn(int boligAreal, int grundAreal, int postNr, int værelser, int etager, int byggeÅr, bool have, Renorvering[] renorveringer)
        {
            // Settings:
            var grundArealProcentSats = 100;
            var værrelseProcentSats = 2;
            var etageProcentSats = 2;
            var haveProcentSats = 5;
            var heltNyBoligÅr = 3;
            var heltNyBoligÅrProcentSats = 10;
            var nyrrerBoligÅr = 15;
            var nyrrerBoligÅrProcentSats = 5;
            var gammelBolig = 30;
            var gammelBoligProcentSats = 5;
            var renorveringProcentSats = 2;

            var postNrPris = await PriceLoader.FindCityPrice(postNr.ToString());
            var basisPris = boligAreal * postNrPris;
            float vurderetPris = basisPris;
            
            if(grundAreal > boligAreal)
            {
                vurderetPris += (grundAreal - boligAreal) * (postNrPris / (grundArealProcentSats));
            }

            if(værelser > 1)
            {
                vurderetPris += basisPris * ((værrelseProcentSats / 100f) * (værelser - 1));
            }

            if (etager > 1)
            {
                vurderetPris += basisPris * ((etageProcentSats / 100f) * (etager - 1));
            }

            if (have)
            {
                vurderetPris += basisPris * (haveProcentSats / 100f);
            }

            if(byggeÅr >= DateTime.Now.AddYears(-heltNyBoligÅr).Year)
            {
                vurderetPris += basisPris * (heltNyBoligÅrProcentSats / 100f);
            }
            else if(byggeÅr >= DateTime.Now.AddYears(-nyrrerBoligÅr).Year)
            {
                vurderetPris += basisPris * (nyrrerBoligÅrProcentSats / 100f);
            }
            else if(byggeÅr <= DateTime.Now.AddYears(-gammelBolig).Year)
            {
                vurderetPris -= basisPris * (gammelBoligProcentSats / 100f);
            }

            var sortedRenorveriner = renorveringer.OrderByDescending(item => item.Ombygningsår).ToArray();

            for(int i = 0; i < sortedRenorveriner.Length; i++)
            {
                var årProcentSats = 0f;
                if(i == 0)
                {
                    if (sortedRenorveriner[i].Ombygningsår >= DateTime.Now.AddYears(-heltNyBoligÅr).Year)
                    {
                        årProcentSats = heltNyBoligÅrProcentSats / 2f;
                    }
                    else if (sortedRenorveriner[i].Ombygningsår >= DateTime.Now.AddYears(-nyrrerBoligÅr).Year)
                    {
                        årProcentSats = nyrrerBoligÅrProcentSats / 2f;
                    }
                }

                int ProcentSatsForRenorveretElement = (i <= renorveringProcentSats ? renorveringProcentSats - i : 1);

                var procentSats = (årProcentSats + 
                    (sortedRenorveriner[i].Køkken ? ProcentSatsForRenorveretElement : 0) + 
                    (sortedRenorveriner[i].Badeværelse ? ProcentSatsForRenorveretElement : 0) + 
                    (sortedRenorveriner[i].Andet ? ProcentSatsForRenorveretElement : 0)
                    ) / 100f;

                vurderetPris += basisPris * procentSats;
            }
            
            return Convert.ToInt32(vurderetPris);
        }
    }
}
