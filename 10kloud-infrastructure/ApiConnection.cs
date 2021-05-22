using _10kloud_AppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _10kloud_infrastructure
{
    class ApiConnection
    {
        static async Task<string> GetApiData(string url)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                var client = new HttpClient();
                HttpResponseMessage ApiResponse = await client.GetAsync(url);
                ApiResponse.EnsureSuccessStatusCode();
                string responseBody = await ApiResponse.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                return null;
            }

            string datainizconv= "%272021-05-19%2008:55:02.509000000%27";
            string datafineconv;
            // formato data %272021-05-19%2008:55:02.509000000%27
            string ApiUrl = await GetApiData("https://3jea5u3n72.execute-api.eu-west-1.amazonaws.com/silos?start=" + datainizconv + "&limit=60");

            SilosDTOs response = JsonSerializer.Deserialize<SilosDTOs>(url);


        }
    }
}
