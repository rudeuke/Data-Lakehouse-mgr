namespace application.Services.ApiService
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetApiResponseAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }

        public async Task<byte[]> GetApiResponseContentAsync(string url)
        {
            var response = await GetApiResponseAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}