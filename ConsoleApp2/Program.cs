using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace OpenWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q=Kazan&appid=ca20dda9ed2f83ce0cc363b556bbcf42";

            var request = WebRequest.Create(url);

            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(httpStatusCode);
                return;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                var geodata = JsonConvert.DeserializeObject<Root>(result);
                Console.WriteLine(geodata.geodata_center.type);
            }
        }
    }
}

