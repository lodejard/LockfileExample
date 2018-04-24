using Examples.CommonCode;
using Serilog;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            logger.Information("Doing work");

            var worker = new SimpleWorker();
            Console.WriteLine(worker.DoWork(new[]
            {
                new[]{"One", "Two"},
                new[]{"Three", "Four"},
            }));

            logger.Information("Telling user to press enter");

            Console.WriteLine("Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
