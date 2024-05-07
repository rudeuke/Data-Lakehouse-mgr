namespace application.Repositories.ApiRepository
{
    public interface IApiRepository
    {
        Task<string> GetApiResponseContentAsync(string url);
    }
}