using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Hello World!");

            //get list of files from the API
            //check if the files exist (and DB)
            //if not, save the files

            File_helper.Save.ToFile(
                Api_helper.Serialization.ReturnTextFromResponse(
                    Api_helper.Request.Get("https://ec.europa.eu/eurostat/api/dissemination/catalogue/toc/txt?lang=en")),
                    "test",
                    Enums.FileExtension.txt);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    string? connectionString = hostContext.Configuration.GetConnectionString("DefaultConnection");

                    if (connectionString != null)
                    {
                        services.AddDbContext<ApplicationDbContext>(options => 
                            options.UseSqlite(connectionString));
                    }
                    else
                    {
                        throw new ArgumentNullException("Connection string is null");
                    }
                });
    }
}