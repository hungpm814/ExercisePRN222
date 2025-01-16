using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientClass
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main()
        {
            string uri = "http://www.contoso.com/";

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Cautch!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
