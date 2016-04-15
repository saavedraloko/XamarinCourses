﻿using System.Threading.Tasks;

namespace WeatherApp
{
    public class Core
    {
        public static async Task<Weather> GetWeather(string zipCode)
        {
            string queryString =
              "https://query.yahooapis.com/v1/public/yql?q=select+*+from+weather.forecast+where+location=" +
               zipCode + "&format=json";

            dynamic results = await DataService.getDataFromService(queryString).ConfigureAwait(false);

            dynamic weatherOverview = results["query"]["results"]["channel"];

            if ((string)weatherOverview["description"] != "Yahoo! Weather Error")
            {
                Weather weather = new Weather();

                weather.Title = (string)weatherOverview["description"];

                dynamic wind = weatherOverview["wind"];
                weather.Temperature = (string)wind["chill"] + " F";
                weather.Wind = (string)wind["speed"] + " mph";

                dynamic atmosphere = weatherOverview["atmosphere"];
                weather.Humidity = (string)atmosphere["humidity"] + " %";
                weather.Visibility = (string)atmosphere["visibility"] + " miles";

                dynamic astronomy = weatherOverview["astronomy"];
                weather.Sunrise = (string)astronomy["sunrise"];
                weather.Sunset = (string)astronomy["sunset"];

                return weather;
            }
            else
            {
                return null;
            }
        }
    }
}