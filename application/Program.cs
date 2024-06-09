using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using application.Repositories.FileRepository;
using application.Services.FileService;
using application.Services.ApiService;
using application.Data;
using application.Configuration;
using application.Domain.Enums;

namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).Wait();
        }

        static async Task MainAsync(string[] args)
        {
            IServiceProvider serviceProvider = CreateHostBuilder(args).Build().Services;

            var apiService = serviceProvider.GetRequiredService<IApiService>();
            var diskFileService = serviceProvider.GetRequiredService<IDiskFileService>();
            var databaseFileService = serviceProvider.GetRequiredService<IDatabaseFileService>();

            // var testData = apiService.GetApiResponseContentAsync("https://ec.europa.eu/eurostat/api/dissemination/catalogue/toc/txt?lang=en");
            var testData = await apiService.GetApiResponseContentAsync("https://http.cat/401");
            	
            // diskFileService.SaveFileToDisk("Test filename", testData.Result, FileExtension.txt);
            databaseFileService.CreateFile("Test filename", testData);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostContext, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHttpClient();

                    services.AddScoped<IApiService, ApiService>();
                    services.AddScoped<IDiskFileService, DiskFileService>();
                    services.AddScoped<IDatabaseFileService, DatabaseFileService>();
                    services.AddScoped<IFilePathProvider, FilePathProvider>();
                    services.AddScoped<IFileStorageConfiguration, FileStorageConfiguration>();

                    services.AddScoped<IFileRepository, FileRepository>();

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