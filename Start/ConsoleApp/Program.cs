﻿using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello DevNetNoord 2023!");

            DocumentProcessor.Processor proc = new DocumentProcessor.Processor();
            var result = await proc.ProcessDocumentAsync("Docs/schedule.pdf","Output/schedule2022.pdf");
            //var result = await proc.ProcessDocumentAsync("https://devnetnoord.nl/","Output/devnetnoord.html");
            
            Console.WriteLine("Done...");
        }
    }
}