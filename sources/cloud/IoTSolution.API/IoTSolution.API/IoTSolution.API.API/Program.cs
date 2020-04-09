using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

#pragma warning disable CS1591
namespace IoTSolution.API.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        //.NET CORE 3.1 way
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
