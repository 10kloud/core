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
    public class ApiConnection
    {
        /* static async Task<string> GetApiData(string ApiUrl)
         {
             // Call asynchronous network methods in a try/catch block to handle exceptions.
             try
             {
                 var client = new HttpClient();
                 HttpResponseMessage ApiResponse = await client.GetAsync(ApiUrl);
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

             string datainizconv = "%272021-05-19%2008:55:02.509000000%27";

             // formato data %272021-05-19%2008:55:02.509000000%27
             string ApiClient = await GetApiData("https://3jea5u3n72.execute-api.eu-west-1.amazonaws.com/silos?start=" + datainizconv + "&limit=60");

             var response = JsonSerializer.Deserialize<Silos[]>(ApiClient);


         }*/



        static async Task<string> GetApi(string url)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                var client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                return null;
            }
        }

        public async Task<IEnumerable<Silos>> GetData()
        {
            string datainizconv = "%272021-05-19%2008:55:02.509000000%27";

            string ApiClient = await GetApi("https://3jea5u3n72.execute-api.eu-west-1.amazonaws.com/silos?start=" + datainizconv + "&limit=60");

            var response = JsonSerializer.Deserialize<Silos[]>(ApiClient);

            return response;

        }
        public async Task<Silos> GetSingleData(int silos_id)
        {
            string datainizconv = "%272021-05-19%2008:55:02.509000000%27";

            string ApiClient = await GetApi("https://3jea5u3n72.execute-api.eu-west-1.amazonaws.com/silos?start=" + datainizconv + "&limit=60");

            var response = JsonSerializer.Deserialize<Silos[]>(ApiClient);
            var GetSilo = (Silos)response.GetValue(silos_id);

            return GetSilo;

        }
        public async Task<IEnumerable<Silos>> GetLevel(int silos_id)
        {
            string datainizconv = "";

            string ApiClient = await GetApi("https://3jea5u3n72.execute-api.eu-west-1.amazonaws.com/level/silo_"+silos_id+"?start=%272021-05-19%2008:55:02.509000000%27&sampling=1800&limit=9000");

            var response = JsonSerializer.Deserialize<Silos[]>(ApiClient);
            

            return response;

        }


    }
}
