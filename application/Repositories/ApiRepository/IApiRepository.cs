namespace application.Repositories
{
    public interface IApiRepository
    {
        Task<string> GetApiResponseContentAsync(string url);
    }
}