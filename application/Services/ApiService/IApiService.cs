namespace application.Services.ApiService
{
    public interface IApiService
    {
        Task<HttpResponseMessage> GetApiResponseAsync(string url);
        Task<string> GetApiResponseContentAsync(string url);
    }
}