using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string _url = @"http://localhost:5000/serverHub";
            var connection = new HubConnectionBuilder()
                .WithUrl(_url)
                .Build();

            connection.StartAsync().Wait();
            connection.InvokeCoreAsync("SendSome", args: new[] { "Hello" });
            connection.On("ReceiveSome", (string item) =>
            {
                Console.WriteLine(item);
            });
            Console.ReadKey();
        }
    }
}
