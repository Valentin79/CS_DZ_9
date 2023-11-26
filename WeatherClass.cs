using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_9
{
    public class WeatherClass
    {
        public class Weather
        {
            public DateTime Time { get; set; }
            public double Temperature { get; set; }
            public int Weathercode { get; set; }
            public double Windspeed { get; set; }
            public int Winddirection { get; set; }
        }

        public class WeatherInfo
        {
            public Weather Current { get; set; }
            public List<Weather> History { get; set; }

            public override string ToString()
            {
                return $"{Current.Time}, {Current.Temperature},{Current.Weathercode} " +
                    $"{Current.Windspeed}, {Current.Winddirection}";
            }
        }
    }
}
