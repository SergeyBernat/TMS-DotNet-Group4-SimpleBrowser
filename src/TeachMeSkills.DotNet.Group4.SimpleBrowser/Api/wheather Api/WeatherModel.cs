using System;
using System.Collections.Generic;

namespace TeachMeSkills.DotNet.Group4.SimpleBrowser.Api.wheather_Api
{
    public class WeatherGeo
    {
        public int distance { get; set; }
        public string title { get; set; }
        public string location_type { get; set; }
        public int woeid { get; set; }
        public string latt_long { get; set; }
    }

    public class ConsolidatedWeather
    {
        public string weather_state_name { get; set; }
        public string weather_state_abbr { get; set; }
        public string wind_direction_compass { get; set; }
        public string applicable_date { get; set; }
        public double min_temp { get; set; }
        public double max_temp { get; set; }
        public double the_temp { get; set; }
        public double wind_speed { get; set; }
        public double air_pressure { get; set; }
    }

    public class WeatherModel
    {
        public IList<ConsolidatedWeather> consolidated_weather { get; set; }
        public DateTime time { get; set; }
        public DateTime sun_rise { get; set; }
        public DateTime sun_set { get; set; }
        public string timezone_name { get; set; }
        public string title { get; set; }
        public string location_type { get; set; }
        public string timezone { get; set; }
    }
}
