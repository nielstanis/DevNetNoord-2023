using System;
using System.Threading.Tasks;
using iLib;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello DevNetNoord 2023!");
            Console.WriteLine($"ConsoleApp - {typeof(System.Net.Http.HttpClient).Assembly.Location}");
            
            var loadContext = new IsolatedLoadContext("../pub/lib.dll", new[]{ typeof(IProcessor) });
            var d = loadContext.CreateInstance<IProcessor>();

            //var result = await d.ProcessDocumentAsync("Docs/schedule.pdf","Output/schedule2022.pdf");
            var result = await d.ProcessDocumentAsync("https://devnetnoord.nl/","Output/devnetnoord.html");
            
            Console.WriteLine("Done...");
        }
    }
}
