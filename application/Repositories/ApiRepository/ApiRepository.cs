using application.Services.ApiService;

namespace application.Repositories
{
    public class ApiRepository : IApiRepository
    {
        private readonly IApiService _apiService;

        public ApiRepository(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<string> GetApiResponseContentAsync(string url)
        {
            var response = await _apiService.GetApiResponseAsync(url);
            return await _apiService.GetApiResponseContentAsync(response);
        }
    }
}