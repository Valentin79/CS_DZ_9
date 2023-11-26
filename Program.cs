using System.Text.Json;
using System.Xml.Serialization;

namespace CS_DZ_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jsonFile = "{\"Current\":{\"Time\":\"2023-06-18T20:35:06.722127+04:00\"," +
                "\"Temperature\":29,\"Weathercode\":1,\"Windspeed\":2.1,\"Winddirection\":1}," +
                "\"History\":[{\"Time\":\"2023-06-17T20:35:06.77707+04:00\",\"Temperature\":29,\"Weathercode\":2,\"Windspeed\":2.4,\"Winddirection\":1}," +
                "{\"Time\":\"2023-06-16T20:35:06.777081+04:00\",\"Temperature\":22,\"Weathercode\":2,\"Windspeed\":2.4,\"Winddirection\":1}," +
                "{\"Time\":\"2023-06-15T20:35:06.777082+04:00\",\"Temperature\":21,\"Weathercode\":4,\"Windspeed\":2.2,\"Winddirection\":1}]}";


            //Десериализуем json в объект класса
            WeatherClass.WeatherInfo? weatherInfo = JsonSerializer.Deserialize<WeatherClass.WeatherInfo>(jsonFile);
            Console.WriteLine(weatherInfo);
            
            //Сериализуем объект класса в xml
            var serialazer = new XmlSerializer(typeof(WeatherClass.WeatherInfo));
            serialazer.Serialize(Console.Out, weatherInfo);


        }


    }
}/*-----------------Получился следующий код--------------->
   <?xml version="1.0" encoding="Codepage - 866"?>
<WeatherInfo xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Current>
    <Time>2023-06-18T19:35:06.722127+03:00</Time>
    <Temperature>29</Temperature>
    <Weathercode>1</Weathercode>
    <Windspeed>2.1</Windspeed>
    <Winddirection>1</Winddirection>
  </Current>
  <History>
    <Weather>
      <Time>2023-06-17T19:35:06.77707+03:00</Time>
      <Temperature>29</Temperature>
      <Weathercode>2</Weathercode>
      <Windspeed>2.4</Windspeed>
      <Winddirection>1</Winddirection>
    </Weather>
    <Weather>
      <Time>2023-06-16T19:35:06.777081+03:00</Time>
      <Temperature>22</Temperature>
      <Weathercode>2</Weathercode>
      <Windspeed>2.4</Windspeed>
      <Winddirection>1</Winddirection>
    </Weather>
    <Weather>
      <Time>2023-06-15T19:35:06.777082+03:00</Time>
      <Temperature>21</Temperature>
      <Weathercode>4</Weathercode>
      <Windspeed>2.2</Windspeed>
      <Winddirection>1</Winddirection>
    </Weather>
  </History>
</WeatherInfo>
  */
        
