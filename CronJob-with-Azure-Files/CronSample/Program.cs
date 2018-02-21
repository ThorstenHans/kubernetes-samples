using System;
using System.IO;

namespace CronSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var folder = Environment.GetEnvironmentVariable("CronJobOutputFolder");
                var target = Path.Combine(folder, $"{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.txt");
                File.WriteAllText(target, "42");
                Environment.Exit(0);
            }
            catch (Exception)
            {
                Environment.Exit(1);
            }
        }
    }
}
