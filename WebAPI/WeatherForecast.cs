using System;

namespace WebAPI
{
    public class WeatherForecast
    {

        //Comment to check 
        public DateTime1 Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
