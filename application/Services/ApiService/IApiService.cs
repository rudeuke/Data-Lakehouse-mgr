namespace application.Services.ApiService
{
    public interface IApiService
    {
        Task<HttpResponseMessage> GetApiResponseAsync(string url);
        Task<byte[]> GetApiResponseContentAsync(string url);
    }
}