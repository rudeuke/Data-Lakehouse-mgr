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

        public async Task<string> GetApiResponseContentAsync(string url)
        {
            var response = await GetApiResponseAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                throw new Exception($"Failed to get response from the API. Status code: {response.StatusCode}");
            }
        }
    }
}