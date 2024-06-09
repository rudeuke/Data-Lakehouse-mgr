using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using application.Repositories.FileRepository;
using application.Services.FileService;
using application.Services.ApiService;
using application.Data;
using application.Configuration;

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
            var databaseFileService = serviceProvider.GetRequiredService<IDatabaseFileService>();

            var testData = await apiService.GetApiResponseContentAsync("https://http.cat/401");
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
                    services.AddScoped<IDatabaseFileService, DatabaseFileService>();

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