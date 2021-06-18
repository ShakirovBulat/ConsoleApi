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
            var ApiKey = "d6c0b34a7864b26a7d1907af5d07d288";
            var url = $"https://apidata.mos.ru/v1/datasets/531/rows?api_key={ApiKey}";
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
            }
        }
    }
}

