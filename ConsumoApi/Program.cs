using Newtonsoft.Json;
using QuickType;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumoApi
{
    internal class Program
    {
        static async Task Main(string[] args)
        {   
            // API de exemplo
            HttpClient client= new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
            var response = await client.GetAsync("users");
            var content = await response.Content.ReadAsStringAsync();

            // Utilizando o pacote Newtonsoft.Json;
            var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Email);
                Console.WriteLine("===================");
            }
        }
    }
}

