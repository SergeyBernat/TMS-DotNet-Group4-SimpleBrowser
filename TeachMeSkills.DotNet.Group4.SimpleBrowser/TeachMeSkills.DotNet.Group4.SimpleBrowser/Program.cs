using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachMeSkills.DotNet.Group4.SimpleBrowser.Api.geolocationIP_Api;
using TeachMeSkills.DotNet.Group4.SimpleBrowser.Api.wheather_Api;


namespace TeachMeSkills.DotNet.Group4.SimpleBrowser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WeatherModel weather = GetWeatherFromAPI().GetAwaiter().GetResult();
            Application.Run(new Form1(weather));
        }

        public static async Task<WeatherModel> GetWeatherFromAPI()
        {
            string ipv4 = await new HttpClient().GetStringAsync("https://api.ipify.org/");
            GeolocationModel geolocation = URL_Geolocation.Url.AppendPathSegments("json", ipv4).SetQueryParams("fields=lat,lon").GetJsonAsync<GeolocationModel>().Result;
            string resGeolat = string.Format(CultureInfo.InvariantCulture, "{0:N1}", geolocation.lat);
            string resGeolon = string.Format(CultureInfo.InvariantCulture, "{0:N}", geolocation.lon);
            var request = await new HttpClient().GetStringAsync(URL_Weather.Url.AppendPathSegments("api", "location", "search").SetQueryParams($"lattlong={resGeolat},{resGeolon}"));
            var response = JsonConvert.DeserializeObject<List<WeatherGeo>>(request);
            return await URL_Weather.Url.AppendPathSegments("api", "location", $"{response.ElementAt(0).woeid}").GetJsonAsync<WeatherModel>();
        }
    }
}
