using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BoBedre.Core.AssetLoaders
{
    public static class CityLoader
    {
        private static Dictionary<string, string> DKZipcodes;

        /// <summary>
        /// Finds a city name based on a zipcode
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public async static Task<string> FindCityName(string zipcode)
        {
            await EnsureDKZipcodes();

            return DKZipcodes.FirstOrDefault(city => city.Key == zipcode).Value;
        }

        /// <summary>
        /// Ensures the zipcodes are loaded
        /// </summary>
        /// <returns></returns>
        private static async Task EnsureDKZipcodes()
        {
            if (DKZipcodes == null)
            {
                //Initialize zipcodes
                string path = Path.Combine(Environment.CurrentDirectory, "Assets\\DKZipcodes.json"); // DKZipcodes comes from a public Github repository
                var jsonString = await File.ReadAllTextAsync(path, Encoding.UTF8);
                DKZipcodes = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonString);
            }
        }
    }
}
