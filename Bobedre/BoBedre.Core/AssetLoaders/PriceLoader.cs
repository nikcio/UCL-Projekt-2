using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BoBedre.Core.AssetLoaders
{
    public class PriceLoader
    {
        private static Dictionary<string, int> PricesOnZipCodes;

        /// <summary>
        /// Finds a city name based on a zipcode
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public async static Task<int> FindCityPrice(string zipcode)
        {
            await EnsurePricesOnZipcodes();

            return PricesOnZipCodes.FirstOrDefault(city => city.Key == zipcode).Value;
        }

        /// <summary>
        /// Ensures the zipcodes are loaded
        /// </summary>
        /// <returns></returns>
        private static async Task EnsurePricesOnZipcodes()
        {
            if (PricesOnZipCodes == null)
            {
                //Initialize zipcodes
                string path = Path.Combine(Environment.CurrentDirectory, "Assets\\PostNrPris.json"); // PostNrPris is based on public information
                var jsonString = await File.ReadAllTextAsync(path, Encoding.UTF8);
                PricesOnZipCodes = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonString);
            }
        }
    }
}
